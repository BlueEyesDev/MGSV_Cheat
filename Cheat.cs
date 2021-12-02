using System.Diagnostics;
	using System.Threading;
	using System.Threading.Tasks;
	class Mem
    {
		static IntPtr WprocessHandle;
		static IntPtr HprocessHandle;
		static Process process = Process.GetProcessesByName("mgsvtpp")[0];
		public Mem() {
			WprocessHandle = Imports.OpenProcess(0x1F0FFF, false, process.Id);
			HprocessHandle = Imports.OpenProcess(0x0010, false, process.Id);
			new Thread(()=> {
				while (true)
					if (Process.GetProcessesByName("mgsvtpp").Length == 0)
						Process.GetCurrentProcess().Kill();
			}) { IsBackground = true }.Start();
			Cheat();
		}
		
		public static Dictionary<string, bool> CheatEnable = new Dictionary<string, bool>() {
			{ "Unlimited", false},
			{ "PingTeleport", false},
			{ "GodMod", false},
			{ "UnlimitedAmmo", false},
			{ "AutoETO", false },
			{ "Night", true },
			{ "Stealth", true}

		};
		public static string Mode { get; set; }
		static IntPtr OffsetPosition { get; set; }
		static IntPtr OffsetMark { get; set; }
		public void Cheat()
		{
			//Ilimited
			new Thread(() =>
			{
                while (true)
                    while (CheatEnable["Unlimited"]) {
						Write(process.MainModule.BaseAddress + 0x2C041C8, new byte[] { 0x40, 0x4B, 0x4C, 0x00 });
						Write(process.MainModule.BaseAddress + 0x2C1265C, new byte[] { 0x40, 0x42, 0x0F, 0x00, 0x40, 0x42, 0x0F, 0x00, 0x40, 0x42, 0x0F, 0x00, 0x40, 0x42, 0x0F, 0x00, 0x40, 0x42, 0x0F, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0xC0, 0xD4, 0x01, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06 });
						Write(process.MainModule.BaseAddress + 0x2C126E4, new byte[] { 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00, 0x80, 0x1A, 0x06, 0x00 });
						Write(process.MainModule.BaseAddress + 0x2C126CC, new byte[] { 0x08, 0x00, 0x00, 0x00 });
						Write(process.MainModule.BaseAddress + 0x2C12748, new byte[] { 0x02, 0x09, 0x3D, 0x00, 0x02, 0x09, 0x3D, 0x00, 0x02, 0x09, 0x3D, 0x00, 0x02, 0x09, 0x3D, 0x00, 0x02, 0x09, 0x3D, 0x00 });
						Write(process.MainModule.BaseAddress + 0x2C126D4, new byte[] { 0x70, 0x17, 0x00, 0x00, 0x70, 0x17, 0x00, 0x00, 0x70, 0x17, 0x00, 0x00 });
					}
			})
			{ IsBackground = true }.Start();

			new Thread(() =>
           		{
                		while (true)
					while (CheatEnable["Stealth"])
                    				WriteProcessMemory((int)WprocessHandle, process.MainModule.BaseAddress + 0x2A5D164, new byte[] { 0xC2, 0x01, 0x00, 0x00 }, 4, ref bytesWritten);
            		}){ IsBackground = true }.Start();
			//PingTeleport
			new Thread(() =>
			{
				while (true)
					while (CheatEnable["PingTeleport"])
					{
						byte[] Status = new byte[5];
						OffsetPosition = 
						NewPointer(Read(NewPointer(Read(NewPointer(Read( NewPointer( Read(process.MainModule.BaseAddress + 0x2BE5F70, 5) ) + 0x118, 5)) + 0x30,5)) + 0x8,5)) + 0xFF0;
						OffsetMark = NewPointer(Read(NewPointer(Read(process.MainModule.BaseAddress + 0x2BDCED8, 5)) + 0x98, 5)) + 0xF88;
						byte[] Marqeur = Read(OffsetMark, 12);
						byte[] noMarker = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
						if (!Marqeur.SequenceEqual(noMarker))
							Write(OffsetPosition, Marqeur);
					}
			}) { IsBackground = true }.Start();

			//GodMod
			new Thread(()=> {
				while (true)
					while (CheatEnable["GodMod"]) {
						Write(process.MainModule.BaseAddress + 0x2C0145C, new byte[] { 0x01, 0x1E, 0xE8, 0x03 });
						Write(process.MainModule.BaseAddress + 0x2BD4060, new byte[] { 0x21, 0x1C, 0x00, 0x00 });
						Write(process.MainModule.BaseAddress + 0x2BD4E60, new byte[] { 0x21, 0x1C, 0x00, 0x00 });
					}
			}) { IsBackground = true }.Start();

			//AutoETO
			new Thread(() => {
				while (true)
					while (CheatEnable["AutoETO"])
					{
						IntPtr FOB1 = NewPointer(Read(NewPointer(Read(NewPointer(Read(process.MainModule.BaseAddress + 0x2C3A5A0, 5)) + 0x18, 5)) + 0x110, 5)) + 0x70;
						IntPtr FOB2 = NewPointer(Read(NewPointer(Read(NewPointer(Read(process.MainModule.BaseAddress + 0x2C00F88, 5)) + 0x10, 5)) + 0x48, 5)) + 0x1E8;
						IntPtr SinglePlayer = NewPointer(Read(NewPointer(Read(NewPointer(Read(process.MainModule.BaseAddress + 0x02C00FF0, 4)) + 0x8, 4)) + 0x60, 4)) + 0xD0;

						Parallel.For(0, 50, i => {
							if (Read(FOB1 + (i * 0x40), 4).SequenceEqual(new byte[] { 0xB8, 0x0B, 0xB8, 0x0B }))
								Write(FOB1 + (i * 0x40), new byte[] { 0x00, 0x00, 0xB8, 0x0B });
						});
						Parallel.For(0, 50, i => {
							if (Read(FOB2 + (i * 0x40), 4).SequenceEqual(new byte[] { 0xB8, 0x0B, 0xB8, 0x0B }))
								Write(FOB2 + (i * 0x40), new byte[] { 0x00, 0x00, 0xB8, 0x0B });

						});
						Parallel.For(0, 350, i => {
							if (Read(SinglePlayer + (i * 0x40), 4).SequenceEqual(new byte[] { 0xB8, 0x0B, 0xB8, 0x0B }))
								Write(SinglePlayer + (i * 0x40), new byte[] { 0x00, 0x00, 0xB8, 0x0B });
						});
					}
			})
			{ IsBackground = true }.Start();

			//TimeFreeze
			new Thread(()=> {
				while (true)
					if (CheatEnable["Night"])
						Write(process.MainModule.BaseAddress + 0x2C0139C, new byte[] { 0xF0, 0x4F, 0x01, 0x00 });
					else
						Write(process.MainModule.BaseAddress + 0x2C0139C, new byte[] { 0xD9, 0x9C, 0x00, 0x00 });

			}) { IsBackground = true }.Start();

			#region A FIX
			//        //Infinited AMMO
			//        new Thread(() => {
			//byte[] PrimarySilent = new byte[4];
			//byte[] PrimarySSilent = new byte[4];
			//byte[] SecondarySilent = new byte[4];
			//while (true)
			//	while (CheatEnable["UnlimitedAmmo"]) {

			//		//Arme Secondaire
			//		Write(NewPointer(Read(process.MainModule.BaseAddress + 0x2BE5F70, 4)) + 0x230, new byte[] { 0xFF, 0x00, 0x00, 0x00 }); //Chargeur Ilimté
			//		//FIX
			//		Write(process.MainModule.BaseAddress + 0x2A5D1F0, new byte[] { 0x01, 0x00, 0xFF, 0xFF });//Infini View
			//		if (!SecondarySilent.SequenceEqual(new byte[4]))
			//			SecondarySilent = Read(NewPointer(Read(process.MainModule.BaseAddress + 0x2BE5F70, 4)) + 0x348, 4);
			//		Write(NewPointer(Read(process.MainModule.BaseAddress + 0x2BE5F70, 4)) + 0x348, SecondarySilent); //Infini Scilencieux

			//		//Arme Principal
			//		Write(NewPointer(Read(process.MainModule.BaseAddress + 0x2BE5F70, 4)) + 0x224, new byte[] { 0xFF, 0x00, 0x00, 0x00 }); //Chargeur Ilimté
			//		//FIX
			//		Write(process.MainModule.BaseAddress + 0x2A5D1E8, new byte[] { 0x01, 0x00, 0xFF, 0xFF }); //Infini View
			//		if (!PrimarySilent.SequenceEqual(new byte[4]))
			//			PrimarySilent = Read(NewPointer(Read(process.MainModule.BaseAddress + 0x2BE5F70, 4)) + 0x228, 4);
			//		Write(NewPointer(Read(process.MainModule.BaseAddress + 0x2BE5F70, 4)) + 0x228, PrimarySilent); //Infini Scilencieux


			//		//Arme Principal Secondaire
			//		Write(NewPointer(Read(process.MainModule.BaseAddress + 0x2BE5F70, 4)) + 0x228, new byte[] { 0xB8, 0x13, 0x5D, 0x02 } ); //Infini Munition
			//		//FIX
			//		Write(process.MainModule.BaseAddress + 0x2A5D1EC, new byte[] { 0x01, 0x00, 0xFF, 0xFF }); //Infini View
			//		if (!PrimarySSilent.SequenceEqual(new byte[4]))
			//			PrimarySSilent = Read(NewPointer(Read(process.MainModule.BaseAddress + 0x2BE5F70, 4)) + 0x22C, 4);
			//		Write(NewPointer(Read(process.MainModule.BaseAddress + 0x2BE5F70, 4)) + 0x22C, PrimarySSilent); //Infini Scilencieux
			//	}
			//        })
			//        { IsBackground = true }.Start();
			#endregion
		}

        private static IntPtr NewPointer(byte[] ReadMemory) {
			ReadMemory = ReadMemory.Reverse().ToArray();
			return new IntPtr(Convert.ToInt64(BitConverter.ToString(ReadMemory).Replace("-", string.Empty), 16));
		}

		private static void Write(IntPtr Offset, byte[] Wbytes) {
			int bytesWritten = 0;
			Imports.WriteProcessMemory((int)WprocessHandle, Offset, Wbytes, Wbytes.Length, ref bytesWritten);
		}

		private static byte[] Read(IntPtr Offset, int Size) {
			int bytesRead = 0;
			byte[] ReadByte = new byte[Size];
			Imports.ReadProcessMemory((int)HprocessHandle, Offset, ReadByte, ReadByte.Length, ref bytesRead);
			return ReadByte;
		}
    }
