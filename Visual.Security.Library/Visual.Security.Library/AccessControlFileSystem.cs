///-----------------------------------
/// Set Directives:
///
/// System.Security.AccessControl
/// Set Roles and Rules.
/// Enumerator File System Access 
///-----------------------------------
using System;
using System.IO;
using System.Security.AccessControl;

namespace VSLFileSystem
{
    class VSLFileAccessSystem
    {
       
        // Adds an ACL entry on the specified file for the specified account.
       public static void VSLAddSecurityToFile(string fileName, string account,
            FileSystemRights rights, AccessControlType controlType)
        {


            // Get a FileSecurity object that represents the
            // current security settings.
            FileSecurity vslSecurity = File.GetAccessControl(fileName);

            // Add the FileSystemAccessRule to the security settings.
            vslSecurity.AddAccessRule(new FileSystemAccessRule(account, rights, controlType));

            // Set the new access settings.
            File.SetAccessControl(fileName, fSecurity);

        }

        // Removes an ACL Security entry on the specified file for the specified account.
        public static void VSLRemoveSecurityFromFile(string fileName, string account,
            FileSystemRights rights, AccessControlType controlType)
        {

            // Get a FileSecurity object that represents the
            // current security settings.
            FileSecurity vslSecurity = File.GetAccessControl(fileName);

            // Remove the FileSystemAccessRule from the security settings.
            vslSecurity.RemoveAccessRule(new FileSystemAccessRule(account, rights, controlType));

            // Set the new access settings.
            File.SetAccessControl(fileName, fSecurity);

        }
    }
}
