   using System.Runtime.InteropServices;
   class Mem
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWrite);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        IntPtr WprocessHandle;
        Process process;
        public Mem(string ProcessName)
        {
            process = Process.GetProcessesByName(ProcessName)[0];
            WprocessHandle = OpenProcess(0x1F0FFF, false, process.Id);

        }
#region Offset
/*
PIM : mgsvtpp.exe + 0x2C041C8 max : 5000000
Materials (Refined)
	Fuel : mgsvtpp.exe+2C1265C max : 1 000 000
	Biological : mgsvtpp.exe+2C12660 max : 1 000 000
	Common Metal : mgsvtpp.exe+2C12664 max : 1 000 000	
	Minor Metal : mgsvtpp.exe+2C12668 max : 1 000 000
	Precious Metal : mgsvtpp.exe+2C1266C max : 1 000 000
Materials (Raw)
	Fuel : mgsvtpp.exe+2C12748 max : 4000002 min : 2
	Biological : mgsvtpp.exe+2C1274C max : 4000002 min : 2
	Common Metal : mgsvtpp.exe+2C12750 max : 4000002 min : 2
	Minor Metal : mgsvtpp.exe+2C12754 max : 4000002 min : 2
	Precious Metal : mgsvtpp.exe+2C12758 max : 4000002 min : 2
Medicinal plant
	Absinthe : mgsvtpp.exe+2C12670 max 120 000
	black carrot : mgsvtpp.exe+2C12674 max 120 000
	Golden croissant : mgsvtpp.exe+2C12678 max 120 000
	Tarragon : mgsvtpp.exe+2C1267C max 120 000
	African Fisheries : mgsvtpp.exe+2C12680 max 120 000
	purpurea : mgsvtpp.exe+2C12684 max 120 000
	Lutea : mgsvtpp.exe+2C12688 max 120 000
	Haoma : mgsvtpp.exe+2C1268C max : 120 000
Transport 
	ZaAZ-S84/4W : mgsvtpp.exe+2C12690 max : 400000
	APE T-41LV : mgsvtpp.exe+2C12694 max : 400000
	Zi-GRA 6T : mgsvtpp.exe+2C12698 max : 400000
	BIAR-53CT : mgsvtpp.exe+2C1269C max : 400000
	ZHUK BR-3 : mgsvtpp.exe+2C126A0 max : 400000
	STOUT IFV-SC : mgsvtpp.exe+2C126A4 max : 400000
	ZHUK RS-ZO : mgsvtpp.exe+2C126A8 max : 400000
	STOUT IFV-FS : mgsvtpp.exe+2C126AC max : 400000
	TT77 NOSOROG : mgsvtpp.exe+2C126B0 max : 400000
	M84A MAGLOADER : mgsvtpp.exe+2C126B4 max : 400000
Walker Gears
	WG.PP : mgsvtpp.exe+2C126B8 max : 400000
	CCCP-WG Type-C : mgsvtpp.exe+2C126BC max : 400000
	CCCP-WG Type-A : mgsvtpp.exe+2C126C0 max : 400000
	CFA-WG Type-C : mgsvtpp.exe+2C126C4 max : 400000
	CFA-WG Type-A : mgsvtpp.exe+2C126C8 max : 400000
Weapons placed
	Mortier M2A-304 : mgsvtpp.exe+2C126E4 max 400000
	HMG-3 WINGATE : mgsvtpp.exe+2C126E8 max 400000
	Mortier M2A-304 : mgsvtpp.exe+2C126EC max 400000
	ZHIZDRA-45 : mgsvtpp.exe+2C126F0 max 400000
	CANON AA M276 : mgsvtpp.exe+2C126F4 max 400000
Parasite
	Mist : mgsvtpp.exe+2C126D4 Max : 6000
	Camouflage :mgsvtpp.exe+2C126D8 Max : 6000
	Armor : mgsvtpp.exe+2C126DC Max : 6000
GodMod - Work FOB
	mgsvtpp.exe+2C0145C = 65543560
	mgsvtpp.exe+2BD4060 = 7560
	mgsvtpp.exe+2BD4E60 = 7560
Night/Day
	mgsvtpp.exe+2C0139C = 86000/45000
Camouflage (if Camo PP equipped) /!\ No Work FOB /!\
	mgsvtpp.exe+2A5D164 = 450
Nuclear weapon : mgsvtpp.exe+2C126CC max : 8
*/
#endregion
		public void Cheat()
        { 
            int bytesWritten = 0;
            while (true) {
                //PIM
                WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2C041C8, new byte[] { 0x40, 0x4B, 0x4C, 0x00 }, 4, ref bytesWritten);
                //Unlimited resource
                WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2C1265C, new byte[] { 0x40, 0x42, 0x0F, 0x00, 0x40, 0x42, 0x0F, 0x00, 0x40, 0x42, 0x0F, 0x00, 0x40, 0x42, 0x0F, 0x00, 0x40, 0x42, 0x0F, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06 }, 111, ref bytesWritten);
                WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2C126E4, new byte[] { 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00 }, 20, ref bytesWritten);
                WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2C126CC, new byte[] { 0x08, 0x00, 0x00, 0x00 }, 4, ref bytesWritten);
                WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2C12748, new byte[] { 0x02, 0x09, 0x3D, 0x00, 0x02, 0x09, 0x3D, 0x00, 0x02, 0x09, 0x3D, 0x00, 0x02, 0x09, 0x3D, 0x00, 0x02, 0x09, 0x3D, 0x00 }, 20, ref bytesWritten);
                WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2C126D4, new byte[] { 0x70, 0x17, 0x00, 0x00, 0x70, 0x17, 0x00, 0x00, 0x70, 0x17, 0x00, 0x00 }, 12, ref bytesWritten);
                //GodMOD
                WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2C0145C, new byte[] { 0x21, 0x1C, 0xE8, 0x03 }, 4, ref bytesWritten);
                WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2BD4060, new byte[] { 0x21, 0x1C, 0x00, 0x00 }, 4, ref bytesWritten);
                WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2BD4E60, new byte[] { 0x21, 0x1C, 0x00, 0x00 }, 4, ref bytesWritten);
                //Invisible
                WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2A5D164, new byte[] { 0xC2, 0x01, 0x00, 0x00 }, 4, ref bytesWritten);
                //Night
                WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2C0139C, new byte[] { 0xF0, 0x4F, 0x01, 0x00 }, 4, ref bytesWritten);
            }
        }
    }
