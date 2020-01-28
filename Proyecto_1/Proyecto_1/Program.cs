using ImapX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ImapClient ic = new ImapClient("secure.emailsrvr.com");
            //var cliente = new ImapClient("secure.emailsrvr.com",888);
            if (ic.Connect())
            {
                ic.Login("dgf@wec.com.mx", "2DE&D#9UbUvN");
                ic.Behavior.FolderTreeBrowseMode = ImapX.Enums.FolderTreeBrowseMode.Lazy;
                ic.Behavior.MessageFetchMode = ImapX.Enums.MessageFetchMode.Attachments;
                ImapX.Collections.CommonFolderCollection fol = ic.Folders;
                //ic.Folders.Inbox.SubFolders[""];
                ic.Folders.Add("Demo");
                ic.Folders.Add("Demo2");
               // ic.Folders["Demo"].Name = "Feliz";
                //ic.Folders["Index"].Messages.
                //ic.Folders["Demo2"].Remove();
                Console.WriteLine("");
                foreach (Folder f in fol)
                {

                    Console.WriteLine(" Folder: " + f.Name);
                    Console.WriteLine(" Folder: " + f.Path);
                    Console.WriteLine(" Folder: " + f.HasChildren);

                }
                Console.WriteLine(ic.IsConnected);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Dentro");
                ic.Logout();

            }
            else
            {
                Console.WriteLine("NO conectaod");
            }
            Console.Read();
        }
    }
}
