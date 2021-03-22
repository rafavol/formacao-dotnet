namespace ByteBank
{
    public class ContaCorrente
    {
        public static int TotalCreatedAccount { get; private set; }

        public double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo;
        private double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value >= 0)
                {
                    _saldo = value;
                }
            }
        }

        private float limite = 0;

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalCreatedAccount++;
            TaxaOperacao = 30 / TotalCreatedAccount;
        }

        public bool Sacar(double valor)
        {
            if ((this._saldo - valor) >= limite)
            {
                this._saldo -= valor;
                return true;
            }
            return false;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if ((this._saldo - valor) < limite)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}
