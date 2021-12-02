using System.Runtime.InteropServices;
	class Imports {
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(int hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWrite);
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
		[DllImport("kernel32.dll")]
		public static extern bool ReadProcessMemory(int hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnhookWindowsHookEx(IntPtr hhk);
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);
		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);
		[DllImport("user32.dll", SetLastError = true)]
		public static extern uint GetWindowLong(IntPtr hWnd, int nIndex);
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetForegroundWindow(IntPtr hWnd);


		public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
	}
