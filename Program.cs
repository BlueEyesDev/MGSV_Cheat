 using System.Windows.Forms;
    class Program
    {
        static Overlay over = new Overlay();
        static bool Showing = false;
        private static IntPtr SetHook(Imports.LowLevelKeyboardProc proc) {
            return Imports.SetWindowsHookEx(WH_KEYBOARD_LL, proc, Imports.GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP && Marshal.ReadInt32(lParam) == 45) {
                if (!Showing)
                    over.Show();
                else
                    over.Hide();
                Showing = !Showing;
            }
            else if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP && Marshal.ReadInt32(lParam) == 222)
            {
          
            }
            return Imports.CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYUP = 0x101;
        private static Imports.LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                while (true) {
                    if (Showing)
                    {
                        over.Invoke(new MethodInvoker(() => {
                            over.Activate();
                        }));
                    }
                }
            }) { IsBackground = true }.Start();
            if (Process.GetProcessesByName("mgsvtpp").Length > 0)
            {
                _hookID = SetHook(_proc);
                new Mem();

            }
            else
            {
                MessageBox.Show("Please Start the game");
                Process.GetCurrentProcess().Kill();
            }
            Application.Run();
        }
    }
