using System;
using System.IO;

namespace CSGO_Cheat_Cleaner_Detector
{
    internal class FilePaths
    {
        // Folder Locations
        private static readonly string Temp = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\Temp"; // Temp
        private static readonly string Temp2 = Path.GetTempPath(); // %Temp%
        private static readonly string Appdata = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Appdata\local"; // Appdata\local
        private static readonly string Appdata2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // %Appdata%
        private static readonly string Appdata3 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Appdata\LocalLow"; // Appdata\LocalLow
        private static readonly string Recent = Environment.GetFolderPath(Environment.SpecialFolder.Recent); // Recent
        private static readonly string Prefetch = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\Windows\Prefetch"; // Prefetch
        private static readonly string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Documents
        private static readonly string Disk = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer); // Main Disk
        private static readonly string ProgramFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
        private static readonly string CSGO = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive"; // CSGO's Folder
        // Folder Locations                                                                                                                                                                                   // Folder Locations

        // Cheats

        public string[] Cheats = {
            Temp + "\\Osiris", Temp2 + "Osiris", Appdata + "\\Osiris", Appdata2 + "\\Osiris", Appdata3 + "\\Osiris", Recent + "\\Osiris", Prefetch + "\\Osiris", Documents + "\\Osiris", Disk + "\\Osiris", ProgramFilesX86 + "\\Osiris", CSGO + "\\Osiris",
            Temp + "\\Nixware", Temp2 + "Nixware", Appdata + "\\Nixware", Appdata2 + "\\Nixware", Appdata3 + "\\Nixware", Recent + "\\Nixware", Prefetch + "\\Nixware", Documents + "\\Nixware", Disk + "\\Nixware", ProgramFilesX86 + "\\Nixware", CSGO + "\\Nixware",
            Temp + "\\Aimfall", Temp2 + "Aimfall", Appdata + "\\Aimfall", Appdata2 + "\\Aimfall", Appdata3 + "\\Aimfall", Recent + "\\Aimfall", Prefetch + "\\Aimfall", Documents + "\\Aimfall", Disk + "\\Aimfall", ProgramFilesX86 + "\\Aimfall", CSGO + "\\Aimfall",
            Temp + "\\GODWARE", Temp2 + "GODWARE", Appdata + "\\GODWARE", Appdata2 + "\\GODWARE", Appdata3 + "\\GODWARE", Recent + "\\GODWARE", Prefetch + "\\GODWARE", Documents + "\\GODWARE", Disk + "\\GODWARE", ProgramFilesX86 + "\\GODWARE", CSGO + "\\GODWARE",
            Temp + "\\PPHUD V3", Temp2 + "PPHUD V3", Appdata + "\\PPHUD V3", Appdata2 + "\\PPHUD V3", Appdata3 + "\\PPHUD V3", Recent + "\\PPHUD V3", Prefetch + "\\PPHUD V3", Documents + "\\PPHUD V3", Disk + "\\PPHUD V3", ProgramFilesX86 + "\\PPHUD V3", CSGO + "\\PPHUD V3",
            Temp + "\\Aurora-Project", Temp2 + "Aurora-Project", Appdata + "\\Aurora-Project", Appdata2 + "\\Aurora-Project", Appdata3 + "\\Aurora-Project", Recent + "\\Aurora-Project", Prefetch + "\\Aurora-Project", Documents + "\\Aurora-Project", Disk + "\\Aurora-Project", ProgramFilesX86 + "\\Aurora-Project", CSGO + "\\Aurora-Project",
            Temp + "\\saphire", Temp2 + "saphire", Appdata + "\\saphire", Appdata2 + "\\saphire", Appdata3 + "\\saphire", Recent + "\\saphire", Prefetch + "\\saphire", Documents + "\\saphire", Disk + "\\saphire", ProgramFilesX86 + "\\saphire", CSGO + "\\saphire",
            Temp + "\\ot", Temp2 + "ot", Appdata + "\\ot", Appdata2 + "\\ot", Appdata3 + "\\ot", Recent + "\\ot", Prefetch + "\\ot", Documents + "\\ot", Disk + "\\ot", ProgramFilesX86 + "\\ot", CSGO + "\\ot",
            Temp + "\\otc", Temp2 + "otc", Appdata + "\\otc", Appdata2 + "\\otc", Appdata3 + "\\otc", Recent + "\\otc", Prefetch + "\\otc", Documents + "\\otc", Disk + "\\otc", ProgramFilesX86 + "\\otc", CSGO + "\\otc",
            Temp + "\\YeahNot_CS", Temp2 + "YeahNot_CS", Appdata + "\\YeahNot_CS", Appdata2 + "\\GODWARE", Appdata3 + "\\GODWARE", Recent + "\\YeahNot_CS", Prefetch + "\\YeahNot_CS", Documents + "\\YeahNot_CS", Disk + "\\YeahNot_CS", ProgramFilesX86 + "\\YeahNot_CS", CSGO + "\\YeahNot_CS",
            Temp + "\\BlazeHack", Temp2 + "BlazeHack", Appdata + "\\BlazeHack", Appdata2 + "\\BlazeHack", Appdata3 + "\\BlazeHack", Recent + "\\BlazeHack", Prefetch + "\\BlazeHack", Documents + "\\BlazeHack", Disk + "\\BlazeHack", ProgramFilesX86 + "\\BlazeHack", CSGO + "\\BlazeHack",
            Temp + "\\Legendware", Temp2 + "Legendware", Appdata + "\\Legendware", Appdata2 + "\\Legendware", Appdata3 + "\\Legendware", Recent + "\\Legendware", Prefetch + "\\Legendware", Documents + "\\Legendware", Disk + "\\Legendware", ProgramFilesX86 + "\\Legendware", CSGO + "\\Legendware",
            Temp + "\\weave", Temp2 + "weave", Appdata + "\\weave", Appdata2 + "\\weave", Appdata3 + "\\weave", Recent + "\\weave", Prefetch + "\\weave", Documents + "\\weave", Disk + "\\weave", ProgramFilesX86 + "\\weave", CSGO + "\\weave",
            Temp + "\\Aimware", Temp2 + "Aimware", Appdata + "\\Aimware", Appdata2 + "\\Aimware", Appdata3 + "\\Aimware", Recent + "\\Aimware", Prefetch + "\\Aimware", Documents + "\\Aimware", Disk + "\\Aimware", ProgramFilesX86 + "\\Aimware", CSGO + "\\Aimware",
            Temp + "\\fatality", Temp2 + "fatality", Appdata + "\\fatality", Appdata2 + "\\fatality", Appdata3 + "\\fatality", Recent + "\\fatality", Prefetch + "\\fatality", Documents + "\\fatality", Disk + "\\fatality", ProgramFilesX86 + "\\fatality", CSGO + "\\fatality",
            Temp + "\\JustGlow", Temp2 + "JustGlow", Appdata + "\\JustGlow", Appdata2 + "\\JustGlow", Appdata3 + "\\JustGlow", Recent + "\\JustGlow", Prefetch + "\\JustGlow", Documents + "\\JustGlow", Disk + "\\JustGlow", ProgramFilesX86 + "\\JustGlow", CSGO + "\\JustGlow",
            Temp + "\\rawetripp", Temp2 + "rawetripp", Appdata + "\\rawetripp", Appdata2 + "\\rawetripp", Appdata3 + "\\rawetripp", Recent + "\\rawetripp", Prefetch + "\\rawetripp", Documents + "\\rawetripp", Disk + "\\rawetripp", ProgramFilesX86 + "\\rawetripp", CSGO + "\\rawetripp",
            Temp + "\\pdr", Temp2 + "pdr", Appdata + "\\pdr", Appdata2 + "\\pdr", Appdata3 + "\\pdr", Recent + "\\pdr", Prefetch + "\\pdr", Documents + "\\pdr", Disk + "\\pdr", ProgramFilesX86 + "\\pdr", CSGO + "\\pdr",
            Temp + "\\LUCKERBY", Temp2 + "LUCKERBY", Appdata + "\\LUCKERBY", Appdata2 + "\\LUCKERBY", Appdata3 + "\\LUCKERBY", Recent + "\\LUCKERBY", Prefetch + "\\LUCKERBY", Documents + "\\LUCKERBY", Disk + "\\LUCKERBY", ProgramFilesX86 + "\\LUCKERBY", CSGO + "\\LUCKERBY",
            Temp + "\\sensum", Temp2 + "sensum", Appdata + "\\sensum", Appdata2 + "\\sensum", Appdata3 + "\\sensum", Recent + "\\sensum", Prefetch + "\\sensum", Documents + "\\sensum", Disk + "\\sensum", ProgramFilesX86 + "\\sensum", CSGO + "\\sensum",
            Temp + "\\Anubis", Temp2 + "Anubis", Appdata + "\\Anubis", Appdata2 + "\\Anubis", Appdata3 + "\\Anubis", Recent + "\\Anubis", Prefetch + "\\Anubis", Documents + "\\Anubis", Disk + "\\Anubis", ProgramFilesX86 + "\\Anubis", CSGO + "\\Anubis",
            Temp + "\\Legithook", Temp2 + "Legithook", Appdata + "\\Legithook", Appdata2 + "\\Legithook", Appdata3 + "\\Legithook", Recent + "\\Legithook", Prefetch + "\\Legithook", Documents + "\\Legithook", Disk + "\\Legithook", ProgramFilesX86 + "\\Legithook", CSGO + "\\Legithook",
            Temp + "\\sByteCSGONew", Temp2 + "sByteCSGONew", Appdata + "\\sByteCSGONew", Appdata2 + "\\sByteCSGONew", Appdata3 + "\\sByteCSGONew", Recent + "\\sByteCSGONew", Prefetch + "\\sByteCSGONew", Documents + "\\sByteCSGONew", Disk + "\\sByteCSGONew", ProgramFilesX86 + "\\sByteCSGONew", CSGO + "\\sByteCSGONew",
            Temp + "\\R41N3W4R3", Temp2 + "R41N3W4R3", Appdata + "\\R41N3W4R3", Appdata2 + "\\R41N3W4R3", Appdata3 + "\\R41N3W4R3", Recent + "\\R41N3W4R3", Prefetch + "\\R41N3W4R3", Documents + "\\R41N3W4R3", Disk + "\\R41N3W4R3", ProgramFilesX86 + "\\R41N3W4R3", CSGO + "\\R41N3W4R3"
            };
        // Cheats

        // Cheats2
        public string[] Cheats2 = {
            Prefetch + "\\OSIRIS.DLL",Prefetch + "\\NIXWARE.DLL",Prefetch + "\\AIMFALL.DLL",Prefetch + "\\GODWARE.DLL",Prefetch + "\\PPHUD V3",Prefetch + "\\Aurora-Project",Prefetch + "\\saphire",Prefetch + "\\ot", Prefetch + "\\otc",Prefetch + "\\YeahNot_CS",Prefetch + "\\BlazeHack",Prefetch + "\\LEGENDWARE.DLL",Prefetch + "\\weave",Prefetch + "\\AIMWARE.DLL",Prefetch + "\\FATALITY.DLL",Prefetch + "\\JustGlow",Prefetch + "\\rawetripp",Prefetch + "\\pdr",Prefetch + "\\LUCKERBY",Prefetch + "\\sensum",Prefetch + "\\Anubis",Prefetch + "\\Legithook",Prefetch + "\\sByteCSGONew",Prefetch + "\\R41N3W4R3"
            };
        // Cheats2


        // Temporary Folders
        public string[] Temporary = {
                Temp,
                Temp2,
                Recent + "\\",
                Prefetch
            };
        // Temporary Folders
    }
}
