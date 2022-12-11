namespace Marcenaria{
  public class Bancada : Movel
    {
        public int portas {get;}
        public int gavetas {get;}
        public string pg {get;}
        
        public Bancada(
               float alt,
               float largura,
               float pd,
               string material,
               string cor,
               int portas,
               int gavetas,
               string pg){
                         this.alt = alt;
                         this.largura = largura;
                         this.pd = pd;
                         this.material = material; 
                         this.cor = cor;
                         this.portas = portas;
                         this.gavetas = gavetas;
                         this.pg = pg;             
                         descricao = "Bancada";
                         switch (material)
         {
                          case "Carvalho americano": 
                            peso = (float)(((alt * largura * pd)/1000000)* 13.9); 
                            preco = (float)((((alt * largura * pd)/ 1000000) + (portas * 1.5) + (gavetas * 1.2)) * 400);  
                    
                          break;
                          case "MDF":  
                            peso = (float)(((alt * largura * pd)/1000000)* 9.3); 
                            preco = (float)((((alt * largura * pd)/ 1000000) + (portas * 1.5) + (gavetas * 1.2)) * 200);  
                    
                          break;
                          case "Pinus":  
                            peso = (float)(((alt* largura * pd)/1000000)* 8.3); 
                            preco = (float)((((alt * largura * pd)/ 1000000) + (portas * 1.5) + (gavetas * 1.2)) * 340);  
                    
                          break;
                          default:  
                            this.material = "MDF";
                            peso = (float)(((alt * largura * pd)/1000000)* 8.3); 
                            preco = (float)((((alt * largura * pd)/ 1000000) + (portas * 1.5) + (gavetas * 1.2)) * 200);  
                    
                          break;
         }
        }
    }
}
