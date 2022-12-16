using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArbolMatematico2 : MonoBehaviour

{

    public GameObject _posicionPizarraOperacionSpawn;

    public GameObject _CuboRespuesta1;
    public GameObject _CuboRespuesta2;
    public GameObject _CuboRespuesta3;

    public TMP_Text _TextoRespuesta1;
    public TMP_Text _TextoRespuesta2;
    public TMP_Text _TextoRespuesta3;

    public int respuestaCorrecta = 0;

    public int escojerOperacion = 0;
    
    // ------------------ Prefabs operaciones --------------------

    public GameObject _Operacion1;  public GameObject _Operacion2;  public GameObject _Operacion3;  public GameObject _Operacion4;  public GameObject _Operacion5;
    public GameObject _Operacion6;  public GameObject _Operacion7;  public GameObject _Operacion8;  public GameObject _Operacion9;  public GameObject _Operacion10;
    public GameObject _Operacion11;  public GameObject _Operacion12;  public GameObject _Operacion13;  public GameObject _Operacion14;  public GameObject _Operacion15;
    public GameObject _Operacion16;  public GameObject _Operacion17;  public GameObject _Operacion18;  public GameObject _Operacion19;  public GameObject _Operacion20;
    public GameObject _Operacion21;  public GameObject _Operacion22;  public GameObject _Operacion23;  public GameObject _Operacion24;  public GameObject _Operacion25;
    public GameObject _Operacion26;  public GameObject _Operacion27;  public GameObject _Operacion28;  public GameObject _Operacion29;  public GameObject _Operacion30;

    // -----------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        Inicialitzar();
       
    }

    public void Inicialitzar(){
        escojerOperacion = Random.Range(1,31);
        OperacionesDeFracciones(escojerOperacion);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OperacionesDeFracciones(int escojerOperacion)
    {

        if      (escojerOperacion == 1)
       {  

        GameObject Operacion = Instantiate(_Operacion1);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
   
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 7;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "1/3";
        _TextoRespuesta2.text = "1"; // correcto
        _TextoRespuesta3.text = "3/6";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 2) 
       {     

        GameObject Operacion = Instantiate(_Operacion2);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";

        _TextoRespuesta1.fontSize = 7;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "3";
        _TextoRespuesta2.text = "1/0";
        _TextoRespuesta3.text = "1/3"; // correcto

        respuestaCorrecta = 3;

       } else if (escojerOperacion == 3) 
       {

        GameObject Operacion = Instantiate(_Operacion3);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "3/2"; // correcto
        _TextoRespuesta2.text = "3/4"; 
        _TextoRespuesta3.text = "4/2";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 4) 
       {

        GameObject Operacion = Instantiate(_Operacion4);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "4/6";
        _TextoRespuesta2.text = "-4/6"; // correcto
        _TextoRespuesta3.text = "4/0";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 5) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion5);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "5/6";
        _TextoRespuesta2.text = "6/15"; 
        _TextoRespuesta3.text = "6/5"; // correcto

         respuestaCorrecta = 3;

       } else if (escojerOperacion == 6) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion6);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "5/3"; // correcto
        _TextoRespuesta2.text = "3/5"; 
        _TextoRespuesta3.text = "-5/3";

        respuestaCorrecta = 1;
       
       } else if (escojerOperacion == 7) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion7);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "8/11";
        _TextoRespuesta2.text = "-2/11"; // correcto
        _TextoRespuesta3.text = "-2/0";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 8) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion8);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "13/16";
        _TextoRespuesta2.text = "7/22"; 
        _TextoRespuesta3.text = "7/11"; // correcto

         respuestaCorrecta = 3;

       } else if (escojerOperacion == 9) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion9);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "4/5"; // correcto
        _TextoRespuesta2.text = "4/10"; 
        _TextoRespuesta3.text = "5/4";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 10) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion10);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "10/9";
        _TextoRespuesta2.text = "10/3"; // correcto
        _TextoRespuesta3.text = "10/6";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 11) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion11);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 7;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "20/5";
        _TextoRespuesta2.text = "5/20"; 
        _TextoRespuesta3.text = "1/2"; // correcto

         respuestaCorrecta = 3;

       } else if (escojerOperacion == 12) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion12);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "2/3"; // correcto
        _TextoRespuesta2.text = "4/6"; 
        _TextoRespuesta3.text = "6/2";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 13) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion13);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "3/34";
        _TextoRespuesta2.text = "4/21"; // correcto
        _TextoRespuesta3.text = "12/63";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 14) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion14);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 7;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "8/10";
        _TextoRespuesta2.text = "1"; 
        _TextoRespuesta3.text = "-4/5"; // correcto

         respuestaCorrecta = 3;

       } else if (escojerOperacion == 15) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion15);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "1/3"; // correcto
        _TextoRespuesta2.text = "1/0"; 
        _TextoRespuesta3.text = "1/2";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 16) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion16);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "5/10";
        _TextoRespuesta2.text = "1/5"; // correcto
        _TextoRespuesta3.text = "5/30";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 17) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion17);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "4/1";
        _TextoRespuesta2.text = "4/6"; 
        _TextoRespuesta3.text = "2/3"; // correcto

         respuestaCorrecta = 3;

       } else if (escojerOperacion == 18) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion18);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 7;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "2/5"; // correcto
        _TextoRespuesta2.text = "10/9"; 
        _TextoRespuesta3.text = "6/4";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 19) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion19);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "12/4";
        _TextoRespuesta2.text = "3/1"; // correcto
        _TextoRespuesta3.text = "6/2";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 20) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion20);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "43/24";
        _TextoRespuesta2.text = "28/98"; 
        _TextoRespuesta3.text = "98/28"; // correcto

         respuestaCorrecta = 3;

       } else if (escojerOperacion == 21) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion21);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "35/6"; // correcto
        _TextoRespuesta2.text = "14/15"; 
        _TextoRespuesta3.text = "21/10";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 22) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion22);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "48/22";
        _TextoRespuesta2.text = "24/11"; // correcto
        _TextoRespuesta3.text = "38/85";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 23) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion23);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "13/11";
        _TextoRespuesta2.text = "11/0"; 
        _TextoRespuesta3.text = "11/13"; // correcto

         respuestaCorrecta = 3;

       } else if (escojerOperacion == 24) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion24);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "12/7"; // correcto
        _TextoRespuesta2.text = "6/56"; 
        _TextoRespuesta3.text = "6/8";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 25) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion25);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "14/10";
        _TextoRespuesta2.text = "14/3"; // correcto
        _TextoRespuesta3.text = "23/8";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 26) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion26);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "4/1";
        _TextoRespuesta2.text = "8/9"; 
        _TextoRespuesta3.text = "1/3"; // correcto

         respuestaCorrecta = 3;

       } else if (escojerOperacion == 27) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion27);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "2/3"; // correcto
        _TextoRespuesta2.text = "90/60"; 
        _TextoRespuesta3.text = "60/90";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 28) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion28);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "-3/4";
        _TextoRespuesta2.text = "-8/9"; // correcto
        _TextoRespuesta3.text = "-5/2";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 29) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion29);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "0/23";
        _TextoRespuesta2.text = "9/0"; 
        _TextoRespuesta3.text = "9/19"; // correcto

         respuestaCorrecta = 3;

       } else if (escojerOperacion == 30) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion30);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico2").transform;
        Operacion.tag = "Operacion2";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "11/16"; // correcto
        _TextoRespuesta2.text = "11/32"; 
        _TextoRespuesta3.text = "18/25";

        respuestaCorrecta = 1;

       } 

    } 

}
