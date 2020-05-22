namespace v5
{
    public class Motor : VehiculoComponentes
    {
        enum TypeEngine
        {
            TWO_TIMES, FOUR_TIMES
        }
        TypeEngine _typeEngine;
        string _id;
        string _cc;
        public Motor(string id, TypeEngine typeEngine, string cc) : base()
        {
            _id = id;
            _typeEngine = typeEngine;
            _cc = cc;
        }
    }
}