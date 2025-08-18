using Demo.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Test
{
    public class CalculadoraTests
    {
        [Fact]// diz que este é um teste, precisa por essa anotação para informar que aqui se faz teste
        public void Calculadora_Somar_DeveRetornarValorSoma()//está na nomeclatura dos testes escrito no onenote 
        {
            // Arrange - Organizar
            var calculadora = new Calculadora(); // instancia a classe que será testada, crio uma classe nova a partir de uma classe existente

            // Act - Agir
            var resultado = calculadora.Somar(10, 20); // chama o método que será testado, aqui é onde eu chamo o método que quero testar, que vem do metodo que eu já esvrevi e puxei pela instanciação da classe


            // Assert - Afirmar
            Assert.Equal(30, resultado); /** aqui eu afirmo que o resultado é igual ao que eu espero, se não for, o teste falha. O Assert é uma classe que tem vários métodos para validar os testes aqui estou usando o Equal para comparar se o resultado é igual ao esperado
                                                    quatro é o valor esperado, resultado é o valor que eu obtive do método Somar, se o resultado for diferente de quatro, o teste falha. */
        }

        [Theory]//diz que este é um teste que vai rodar várias vezes com valores diferentes
        [InlineData(1,1,2)]//valores que vão ser passados para o teste
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 6)]
        [InlineData(5, 5, 10)]
        public void Calculadora_Somar_DeveRetornarVariasSomas(double v1, double v2, double total)
        {
            //arrange
            var calculadora = new Calculadora();

            //act
            var resultado = calculadora.Somar(v1, v2);

            //assert
            Assert.Equal(total, resultado);
        }
    }
}
//depois disso vou em teste e dou um clique direito em cima do projeto e vou em executar testes, ele vai rodar o teste que eu escrevi, se tudo estiver certo, o teste passa, se não, o teste falha.

public class CalculadoraTests
{
    [Fact]
    public void Calculadora_Dividir_DeveDividirValoresCoretament()
    {
        //arrange
        var calculadora = new Calculadora();

        //act
        var resultado = calculadora.dividir(10, 2);

        //assert
        Assert.Equal(5, resultado);

    }
    [Theory]
    [InlineData(10,2,5)]
    [InlineData(20, 4, 5)]
    [InlineData(30, 6, 5)]
    [InlineData(100, 20, 5)]
    [InlineData(50, 10, 5)]
    [InlineData(0, 1, 0)] // Teste de divisão por 1

    public void Calculadora_Dividir_DeveRetornarDivisaoDeVarios(int v1, int v2, int total)
    {
        //arrange
        var calculadora = new Calculadora();

        //act
        var resultado = calculadora.dividir(v1, v2);

        //assert
        Assert.Equal(total, resultado);
    }

}
