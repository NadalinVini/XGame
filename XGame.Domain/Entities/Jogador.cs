using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.ValueObjects;

namespace XGame.Domain
{
    public class Jogador : Notifiable
    {        
        public Guid Id { get; set; }
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public String Senha { get; set; }
        public EnumSituacaoJogador Status { get; set; }

        public Jogador()
        {

        }

        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;


            new AddNotifications<Jogador>(this)
                .IfNotEmail(x => x.Email.Endereco, "Informe um e-mail válido")
                .IfNullOrEmptyOrInvalidLength(x=> x.Senha, 6, 32, "A senha deve ter entre 6 a 32 letras");


        }
    }
}
