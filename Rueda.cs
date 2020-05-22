namespace v5
{
    public class Rueda
    {
        enum Covering
        {
            FENOL, HULE, POLIURETANO
        }
        Recubrimiento _recubrimiento;
        public Rueda(Recubrimiento recubrimiento)
        {
            _recubrimiento = recubrimiento;
        }
        
    }
}