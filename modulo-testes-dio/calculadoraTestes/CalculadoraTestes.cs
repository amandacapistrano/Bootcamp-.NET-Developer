using calculadora.Services;
namespace calculadoraTestes;

public class calculadoraTestes
{
    private CalculadoraImp _calc;
    public calculadoraTestes(){
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //arrange
        int num1 = 5;
        int num2 = 10;

        //act
        int resultado = _calc.Somar(num1, num2);

        //assert
        Assert.Equal(15, resultado);
    }
    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //arrange
        int num1 = 10;
        int num2 = 10;

        //act
        int resultado = _calc.Somar(num1, num2);

        //assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveRetornar2ComoParERetornarTrue()
    {
        //arrange
        int num = 2;

        //act
        bool resultado = _calc.Par(num);

        //assert
        Assert.True(resultado);
    }
}