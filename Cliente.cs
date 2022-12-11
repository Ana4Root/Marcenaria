using System;
namespace Marcenaria{
    public class Cliente{
            public string nome;
            public string cpf;
            public Date datadenascimento;
            public string telefone;
            public string email;
            public string endereço;

                public void setNome(string nome){ 
                    this.nome = nome; 
                }
                public void setCpf(string cpf){ 
                    this.cpf = cpf;
                }
                public void setEmail(string email){ 
                    this.email = email; 
                }
                public void setTelefone(string telefone){
                    this.telefone = telefone;
                }
                public void setNascimento(string datadenascimento){
                    this.datadenascimento = datedenascimento; 
                }
                public void setEndereco(string endereco){ 
                    this.endereco = endereco; 
                }

    
    }
}