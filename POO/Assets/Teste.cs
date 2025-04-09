using UnityEngine;
public class Teste : MonoBehaviour
{ 
    Carro fusca = new Carro();
    Carro gol = new Carro();
    
    void Start()
    {
        fusca.AtribuirNome("Fusca de Pai");
        fusca.AtribuirCor("Amarelo");
        fusca.AtribuirNumero_de_rodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log("O "+ fusca.NomeDoCarro());
        
        gol.AtribuirNome("Gol do Falstão");
        gol.AtribuirCor("Verde");
        gol.AtribuirNumero_de_rodas(4);
        gol.AtribuirPreco(3000.00f);
        Debug.Log("O "+ gol.NomeDoCarro());
    }
    void Update()
    {
        
    }
}
