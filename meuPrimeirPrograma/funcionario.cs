public abstract class Funcionario : PessoaFisica{

    public string Nome { get; set; }
    public string CPF { get; set; }
    public double Salario { get; set; }
    public double Comissao { get; set; }
    
    protected double _bonificacao;
    
    public virtual double Bonificacao
    {
        get
        {
            return _bonificacao;
        }
        set
        {
            _bonificacao += Salario * 0.01;
        }
    }
    public abstract int calcularFerias ();

    public double RenumeracaoTotal(double Salario){
        return Salario * 12 + Salario;
    }

     public double RenumeracaoTotal(double Salario, double Bonificacao){
        return Salario * 12 + Salario + Bonificacao;
    }

    

}