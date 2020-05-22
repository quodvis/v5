namespace v5
{
    public class Rueda
    {
        enum Covering
        {
            FENOL, HULE, POLIURETANO
        }
        Covering _recubrimiento;
        public Rueda(Covering recubrimiento)
        {
            _recubrimiento = recubrimiento;
        }

    }
}