using System;

public class Command {

//---------- Attributes ----------
    private string[] input = new string[1];
    private string operation;
    private string target;
    private string[] arguments = new string[3];
    
//---------- Constructor ----------

    public Command (string raw_input){
        Array.Resize(ref this.input, raw_input.Split(' ').Length); 
        //On resize input[] à la taille du nombre de mots dans raw_input
        this.input = raw_input.Split(' ');
        //input[] : tableau avec la liste des mots saisis
        HandleCommand();
        //On sépare : la commande|la cible|les arguments
    }

//---------- Getters/Setters ----------

    public string get_operation(){
        return this.operation;
    }
    public string get_target(){
        return this.target;
    }
    public string[] get_arguments(){
        return this.arguments;
    }

//---------- Functions ----------

    public void HandleCommand (){
        this.operation = input[0];
        this.target = input[1];

        int arg_index = 0;
        for (int i = 2; i < (this.input.Length); i++){
            this.arguments[arg_index] = this.input[i];
            //On récup les arguments dans input[] et on les met dans arguments[]
            //On commence à 2 car : input[0]=commande et input[1]=cible
            arg_index = arg_index+1;
            //Arg_index : index du dernier argument dans le tableau arguments[]
            Array.Resize(ref this.arguments, arg_index+1);
        }

    }


}