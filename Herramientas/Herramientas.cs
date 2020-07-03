namespace Ventas_MN.Herramientas
{
    class Herramientas
    {
        public int Codigo_Seleccionado(string s)
        {
            if (s.IndexOf(".") > -1)
            {
                int r = 0;
                string n = s.Substring(0, s.IndexOf("."));

                if (int.TryParse(n, out r) == true)
                {
                    return r;
                }
                else
                {
                    return 0;
                }            
            }
            else
            {
                return 0;
            }
        }

        public string Unir(string a, string b, string c = " AND ")
        {
            if (a == null)
            {
                a = "";
            }
            if (a.Length > 0)
            {
                if (b.Length > 0)
                {
                    a = $"{a} {c} {b}";
                }
            }
            else
            {
                if (b.Length > 0)
                {
                    a = b;
                }
            }
            return a;
        }

    }
}
