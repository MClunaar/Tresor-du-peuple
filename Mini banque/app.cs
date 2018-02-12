using System;

public class Application
{
	

	static void Main(){
//---------- Début du programme ----------

		Client[] clients = new Client[1];
		int client_number = 0;
		bool mainloop = true;

		while (mainloop == true){

			Console.Write("Saisir une commande : "); 
			Command action = new Command(Console.ReadLine());

			//############# NE PAS TOUCHER C'EST FULL BUG C'EST POUR TESTER ############
			Console.WriteLine("Action : "+action.get_operation()+"\nTarget : "+action.get_target()+"\nArgument 0 : "+action.get_arguments()[0]);
			//Pour tester que la commande a été traitée

			//Tout ca ajoute un client si on met "add client"+ un nom
			if (action.get_operation() == "add"){
				if (action.get_target() == "client"){
					if (action.get_arguments()[0] != ""){
						client_number += 1;
						Array.Resize(ref clients, client_number+1);
						clients[client_number] = new Client("idtest",action.get_arguments()[0],"Pierre","42 rue lazarus","en fer","samuel.hayden@uac.com","35625","06.66.66.66.66","08/08/1999");
						Console.WriteLine("Vous avez enregistré le client : "+clients[client_number].get_name()+" "+clients[client_number].get_last_name());
					} else {
						Console.WriteLine("Erreur de saisie");
					}
					Console.WriteLine("Nombre de clients enregistés : "+client_number+"\n");
				}
			}
			//###########################################################################

			string looo = Console.ReadLine();
		}
//---------- Fonctions ----------

//---------- Fin du programme ----------
	}
}
