using System;

namespace Security_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = @"]|d3gaj3r3avcvrgz}t>xvj3k\a3pzc{va=3v=t=3zg3`{|f.w3grxv3r3`gaz}t31{v..|3d|a.w13r}w?3tzev}3g{v3xvj3z`31xvj1?3k|a3g{v3uza`g3.vggva31{13dzg{31x1?3g{v}3k|a31v13dzg{31v1?3g{v}31.13dzg{31j1?3r}w3g{v}3k|a3}vkg3p{ra31.13dzg{31x13rtrz}?3g{v}31|13dzg{31v13r}w3`|3|}=3j|f3~rj3f`v3z}wvk3|u3p|z}pzwv}pv?3[r~~z}t3wz`gr}pv?3xr`z`xz3vkr~z}rgz|}?3`grgz`gzpr.3gv`g`3|a3d{rgveva3~vg{|w3j|f3uvv.3d|f.w3`{|d3g{v3qv`g3av`f.g=";
            Cesar Cesar = new Cesar(text);
            Cesar.Decrypt();
            Console.WriteLine(Cesar.getAnswer());
            Console.ReadKey();
        }
    }

    internal sealed class Cesar
    {
        public string code;
        public string answer;

        public Cesar(string code)
        {
            this.code = code;
        }

        public string getAnswer()
        {
            return this.answer;
        }

        public void Decrypt()
        {
            for (int i = 0; i < 256; i++)
            {
                int letterCount = 0;
                int spaceCount = 0;
                string text = xor(i);

                foreach (char symb in text)
                {
                    if (Char.IsLetter(symb) || symb == '=') letterCount++;
                    if (Char.IsWhiteSpace(symb)) spaceCount++;
                }

                if ((((float)letterCount / text.Length) > 0.7) && (((float)spaceCount / text.Length) > 0.12))
                {
                    this.answer = text;
                    break;
                }
            }
            return;
        }

        protected string xor(int key)
        {
            string text = "";

            foreach (char symb in this.code)
            {
                text += (char)(symb ^ key);
            }

            return text;
        }
    }


}
