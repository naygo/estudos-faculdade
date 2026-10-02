# fabricadecarros
EXERCÍCIO DE HERANÇA: generalização e especialização

QUESTÃO 1:

1 - Criar a classe abstrata de nome FabricaDeCarros com os seguintes métodos abstratos: 
  a. CarroSedan criarCarroSedan(); 
  b. CarroPopular criarCarro Popular(); 
  c. Estático void teste(); 

2 - Criar a classe de nome FabricaFiat herdando de FabricaDeCarros com os seguintes métodos: 
  a. CarroSedan criarCarroSedan() 
    * Deve retornar um Siena. 
  b. CarroPopular criarCarroPopular() 
    * Deve retornar um Palio();
  
3. Criar a classe abstrata CarroPopular() com o método: 
  a. void exibirInfoPopular(); 

4. Criar a classe abstrata CarroSedan() com o método: 
  a. void exibirInfoSedan(); 

5. Criar a classe Palio herdando da classe CarroPopular 
  a. O método desta classe deve imprimir Modelo, Fábrica, Categoria e Número Chassis. 
  Cada um destes dados em uma linha; Dados devem ser lidos de atributos. 

6. Criar a classe Siena herdando da classe CarroSedan 
  a. O método desta classe deve imprimir Modelo, Fábrica, Categoria e Número Chassis. 
  Cada um destes dados em uma linha; Dados devem ser lidos de atributos. 

7. Faça um método para  teste na classe FabricaFiat com a seguinte implementação: 
  a.  Crie uma variável fabrica do tipo FabricaDeCarro e instancie com um objeto do tipo FabricaFiat. 
  b. Criar uma variável sedan do tipo CarroSedan e usar a instancia fabrica para criar um objeto CarroSedan; 
  c. Criar uma variável popular do tipo CarroPopular e usar a instancia fábrica para criar um objeto CarroPopular; 
  d. Usar os métodos de exibir do Palio e do Siena para imprimir os dados dos objetos sedan e popular. 
  
QUESTÃO 2:  

8. Criar uma nova categoria de carro picape, no caso da Fiat é a Strada, faça as alterações para que tenhamos a classe completa. 
Altere o método de teste da classe  FabricaFiat e faça o mesmo teste para a classe Strada. 

QUESTÃO 3:

9. Com base na classe Fiat criar as classes FabricaWV, com os carros Gol, Voyage e Saveiro. 
Criar os mesmos testes para a classe FabricaWV. 
