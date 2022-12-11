using System;
using System.Collections.Generic;

namespace Marcenaria{
    public class pedido{
            public Cliente cliente;
            public List<Movel> newmovel;
            private string tipo_frete;
            private string valor_frete {get; private set;}
            private float endereco_entrega;
            public DateTime data_entrega {get; private set;}
            public DateTime prazo_fabricacao {get; private set;}
            public DateTime data_pedido {get;}
            public float valor {get; private set;}
            float fatura = 0;
            float TP = 0;

            public pedido(){
                this.data_pedido = DateTime.now();
                newmovel = new List<Movel>();
            }

            public void calcularValorTotal()
            {
                foreach (var movel in newmovel)
                {
                    fatura += movel.preco;
                    valor = fatura + valor_frete;
                }
            }

            public void calcularValorFrete() 
            {
                switch (tipo_frete)
                {
                    case "Na Loja":
                        valor_frete = 0;
                    break;
                    case "Entrega":
                        
                        if (endereco_entrega == "Tupa")
                        {
                            foreach (var movel in newmovel)
                            {
                                TP += movel.peso;
                                valor_frete = TP * 10;
                            }
                            data_entrega = 40;
                        }
                        else
                        {
                            foreach (var movel in newmovel)
                            {
                                TP += movel.peso;
                                valor_frete = TP * 20;
                            }
                            data_entrega = 60;
                        }
                    break;
                    default: 
                        tipo_frete = "Na Loja";
                        data_entrega = 0;
                        valor_frete = 0;
                        break;
                }
        }
}