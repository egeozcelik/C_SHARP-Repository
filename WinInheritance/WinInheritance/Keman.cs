namespace WinInheritance
{
    class Keman : MuzikAleti
    {
        public bool Klasik { get; set; }

        public override string ToString()
        {
            return "Keman";
        }
        public override string SesVer()
        {
            return "Keman Sesi";
        }
    }
}