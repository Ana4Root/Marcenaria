namespace Marcenaria{
  public class Gaveteiro : Movel
    {
        public int gavetas {get;}
        public string posicaoGavetas {get;}
        public Gaveteiro(
               float alt,
               float largura,
               float pd,
               string material,
               string cor,
               int gavetas,
               string pg){
                         this.alt = alt;
                         this.largura = largura;
                         this.pd = profundidade;
                         this.material = material;
                         this.cor = cor;
                         this.gavetas = gavetas;
                         this.pg= pg;
                         descricao = "Gaveteiro";
                         switch (material)
         {
                          case "Carvalho americano":  
                            peso = (float)(((alt * largura * pd)/1000000)* 13.9); 
                            preco = (float)((((alt * largura * pd)/ 1000000) + (gavetas * 1.2)) * 380);  
                                
                          break;
                          case "MDF":  
                            peso = (float)(((alt * largura * pd)/1000000)* 9.3); 
                            preco = (float)((((alt * largura* pd)/ 1000000) + (gavetas * 1.2)) * 200);  
                                
                          break;
                          case "Pinus":  
                            peso = (float)(((alt * largura * pd)/1000000)* 8.3); 
                            preco = (float)((((alt * largura * pd)/ 1000000) + (gavetas * 1.2)) * 340);  
                                
                          break;
                          default:  
                            this.material = "MDF";
                            peso = (float)(((alt * largura * pd)/1000000)* 8.3); 
                            preco = (float)((((alt * largura * pd)/ 1000000) + (gavetas * 1.2)) * 200);  
                                
                          break;
         }
        }
    }
}