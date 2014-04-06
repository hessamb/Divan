using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
namespace Divan
{
    partial class DivanDataContext
    {
        private static DivanDataContext instance;

        public static DivanDataContext Instance {
            get{
                if(instance==null)
                    instance=new DivanDataContext();
                return instance;
            } 
        }

        public static void BackupDatabase(string backUpFile)
        {
            ServerConnection con = new ServerConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\works\Work\.Net\Divan\Divan\bin\Debug\Database.mdf;Integrated Security=True;Connect Timeout=30");
            Server server = new Server(con);
            Backup source = new Backup();
            source.Action = BackupActionType.Database;
            source.Database = "divan";
            BackupDeviceItem destination = new BackupDeviceItem(backUpFile, DeviceType.File);
            source.Devices.Add(destination);
            source.SqlBackup(server);
            con.Disconnect();
        }
    }
}
