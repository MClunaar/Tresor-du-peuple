using System;


public class Client {

//---------- Attributes ----------//
    private string id_client;
    private string last_name;
    private string name;
    private string adress1;
    private string adress2;
    private string city;
    private string mail_adress;
    private string zip_code;
    private string phone_num;
    private string birthdate;

//---------- Getters/Setters ----------//
    public string get_last_name(){
        return this.last_name;
    }
    public string get_name(){
        return this.name;
    }
    public string get_id(){
        return this.id_client;
    }
    public void set_id(string updt_id_client){
        this.id_client = updt_id_client;
    }

//---------- Constructors ----------//

    public Client (
        string new_id_client,
        string new_last_name,
        string new_name,
        string new_adress1,
        string new_city,
        string new_mail_adress,
        string new_zip_code,
        string new_phone_num,
        string new_birthdate,
        string new_adress2 = null
        ){

        this.id_client = new_id_client;
        this.last_name = new_last_name;
        this.name = new_name;
        this.adress1 = new_adress1;
        this.adress2 = new_adress2;
        this.city = new_city;
        this.mail_adress = new_mail_adress;
        this.zip_code = new_zip_code;
        this.phone_num = new_phone_num;
        this.birthdate = new_birthdate;
    }

//---------- Fonctions ----------//

}
