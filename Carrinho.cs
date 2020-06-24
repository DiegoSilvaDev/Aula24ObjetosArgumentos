using System;
using System.Collections.Generic;

namespace ObjetosArgumentos
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        // 
        public void Adicionar(Produto _prod){
            carrinho.Add(_prod);
        }

        public void Deletar(Produto _p){
            carrinho.Remove(_p);
        }

        public void Ler(){
            foreach(Produto item in carrinho){
                System.Console.WriteLine("{0} - {1:c}",item.Nome,item.Preco);
            }
        }
        
        public void Alterar(int _cod,Produto _produtoAlterado){
            carrinho.Find(z => z.Codigo == _cod).Nome = _produtoAlterado.Nome;
            carrinho.Find(z => z.Codigo == _cod).Preco = _produtoAlterado.Preco;
        }

        public void MostrarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Valor total da compra {0:c}",ValorTotal);
            Console.ResetColor();
        }





    }
}