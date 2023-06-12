using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // � necess�rio para conseguir usar o Text

public class Roletaviciada : MonoBehaviour
{
    int[,] table = new int[5, 5]; //Criando um array 5x5 do tipo int
    string[,] tablestring = new string[5, 5]; //Criando um array 5x5 do tipo string


    //Variaveis para colocar o texto do canvas no inspector
    public Text txt;
    public Text txt2;


    private void Start()
    {
        GerarNumeros(); //Chamando as Fun��es
        GerarNumerosUnicos();
    }


    //Gerando N�meros Apenas
    public void GerarNumeros()
    {
        string arrayString = ""; //Variavel que vai guardar os numeros gerados em um texto.

        for (int l = 0; l < 5; l++) //For para criar as linhas da matriz
        {
            for (int c = 0; c < 5; c++) // For para criar as colunas
            {
                //Preenchendo as colunas com numeros alet�rios
                table[c, l] = Random.Range(0, 100); //De acordo com o index do for, estamos preenchendo com n�meros.
                tablestring[c, l] = table[c, l].ToString(); //Convertendo os numeros gerados de int para string
                arrayString += tablestring[c, l] + " "; //Adicionando os numeros da variavel que vai exibilos, e add um espa�o " "
            }
            arrayString += "\n"; //Gerando a quebra de linha
        }
        txt.text = arrayString; //Exibindo Numero na UI
    }



    //Gerando N�meros �nicos

    public void GerarNumerosUnicos()
    {
        string arrayString = "";
        List<int> usedNumbers = new List<int>(); // Lista para armazenar os n�meros j� utilizados

        for (int l = 0; l < 5; l++)
        {
            for (int c = 0; c < 5; c++)
            {
                int randomNumber = Random.Range(0, 100);
                while (usedNumbers.Contains(randomNumber)) // Verifica se o n�mero j� foi utilizado
                {
                    randomNumber = Random.Range(0, 100); // Gera um novo n�mero aleat�rio
                }

                table[c, l] = randomNumber;
                tablestring[c, l] = table[c, l].ToString();
                arrayString += tablestring[c, l] + " ";
                usedNumbers.Add(randomNumber); // Adiciona o n�mero � lista de n�meros utilizados
            }
            arrayString += "\n"; // Adiciona uma quebra de linha no final de cada linha
        }

        txt2.text = arrayString; //Exibindo o numero na UI
    }

}
