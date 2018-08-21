using System;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using UIKit;

namespace AppBug4635
{
    public class MainViewController : UIViewController
    {
        UILabel logSummary = new UILabel() { Lines = 0 };
        public override async void ViewDidLoad()
        {

            base.ViewDidLoad();
            View.BackgroundColor = UIColor.White;
            View.AddSubview(logSummary);
            logSummary.Frame = View.Frame;
            // Handle when your app starts


            var dbConn = new DbContext();
            StringBuilder logText = new StringBuilder();

            // Delete database if exists
            try
            {
                if (File.Exists(dbConn.DatabasePath))
                    File.Delete(dbConn.DatabasePath);
            }
            catch (Exception ex)
            {
                logText.AppendLine("Error:\tCan't delete old database !\n\n" + ex.ToString());
                WriteAndDisplayLog(logText.ToString());
                return;
            }

            // Initialize database
            try
            {
                await dbConn.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                logText.AppendLine("Error:\tCan't create new database !\n\n" + ex.ToString());
                WriteAndDisplayLog(logText.ToString());
                return;
            }

            // Insert data in OkNullableEntities
            try
            {
                await dbConn.OkNullableEntities.AddAsync(new Model.OkNullableEntity());
                await dbConn.SaveChangesAsync();
                logText.AppendLine("Success:\tAdding data to OkNullableEntities (4 fields with nullable) : OK");
            }
            catch (Exception ex)
            {
                logText.AppendLine("Error:\tAdding data to OkNullableEntities (4 fields with nullable) : ERROR\n\n" + ex.ToString());
                WriteAndDisplayLog(logText.ToString());
                return;
            }

            // Insert data in OkNotNullableEntities
            try
            {
                await dbConn.OkNotNullableEntities.AddAsync(new Model.OkNotNullableEntity());
                await dbConn.SaveChangesAsync();
                logText.AppendLine("Success:\tAdding data to OkNullableEntities (14 fields without nullable) : OK");
            }
            catch (Exception ex)
            {
                logText.AppendLine("Error:\tAdding data to OkNotNullableEntities (14 fields without nullable) : ERROR\n\n" + ex.ToString());
                WriteAndDisplayLog(logText.ToString());
                return;
            }

            // Insert data in BuggedNullableEntities
            try
            {
                await dbConn.BuggedNullableEntities.AddAsync(new Model.BuggedNullableEntity());
                await dbConn.SaveChangesAsync();
                logText.AppendLine("Success:\tAdding data to BuggedNullableEntities (5 fields with nullable) : OK");
            }
            catch (Exception ex)
            {
                logText.AppendLine("Error:\tAdding data to BuggedNullableEntities (5 fields with nullable) : ERROR\n\n" + ex.ToString());
                WriteAndDisplayLog(logText.ToString());
                return;
            }

            // Insert data in BuggedNotNullableEntities
            try
            {
                await dbConn.BuggedNullableEntities.AddAsync(new Model.BuggedNullableEntity());
                await dbConn.SaveChangesAsync();
                logText.AppendLine("Success:\tAdding data to BuggedNotNullableEntities (15 fields without nullable) : OK");
            }
            catch (Exception ex)
            {
                logText.AppendLine("Error:\tAdding data to BuggedNotNullableEntities (15 fields without nullable) : ERROR\n\n" + ex.ToString());
                WriteAndDisplayLog(logText.ToString());
                return;
            }
            // Insert data in BuggedLargerNullableEntities
            try
            {
                await dbConn.BuggedLargerNullableEntities.AddAsync(new Model.BuggedLargerNullableEntity());
                await dbConn.SaveChangesAsync();
                logText.AppendLine("Success:\tAdding data to BuggedLargerNullableEntities (5 fields without nullable + 7 field with nullable) : OK");
            }
            catch (Exception ex)
            {
                logText.AppendLine("Error:\tAdding data to BuggedLargerNullableEntities (5 fields without nullable + 7 field with nullable) : ERROR\n\n" + ex.ToString());
                WriteAndDisplayLog(logText.ToString());
                return;
            }
            WriteAndDisplayLog(logText.ToString());
        }

        void WriteAndDisplayLog(string logMessages)
        {
            Console.WriteLine('\n'+logMessages);
            logSummary.Text = logMessages;
        }
    }
}
