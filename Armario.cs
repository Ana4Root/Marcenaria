namespace Marcenaria{
  public class Armario : Movel
    {
          public int portas {get;}
          public Armario(
                 float alt,
                 float largura,
                 float pd,
                 string material,
                 string cor,
                 int portas){
                           this.portas= portas;
                           this.alt = alt;
                           this.largura = largura;
                           this.pd = pd;
                           this.material = material;
                           this.cor = cor;
                           descricao = "Armario";
                           switch (material)
           {
                            case "Carvalho americano":  
                              peso = (float)(((alt * largura * pd)/1000000)* 13.9); 
                              preco = (float)((((alt * largura * pd)/ 1000000) + (portas * 1.5)) * 500);  
                            
                            break;
                            case "MDF":   
                              peso = (float)(((alt* largura * pd)/1000000)* 9.3); 
                              preco = (float)((((alt * largura * pd)/ 1000000) + (portas * 1.5)) * 200);  
                            
                            break;
                            case "Pinus":   
                              peso = (float)(((alt * largura * pd)/1000000)* 8.3); 
                              preco = (float)((((alt * largura * pd)/ 1000000) + (portas * 1.5)) * 370);  
                            
                            break;
                            default:  
                              this.material = "MDF";
                              peso = (float)(((alt * largura * pd)/1000000)* 9.3); 
                              preco = (float)((((alt * largura * pd)/ 1000000) + (portas * 1.5)) * 200);  
                            
                            break;
           }            
          }
      
        

      
  }
}