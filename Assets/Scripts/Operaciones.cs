using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Operaciones : MonoBehaviour

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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
   
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";  

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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "7/6"; // correcto
        _TextoRespuesta2.text = "3/5"; 
        _TextoRespuesta3.text = "9/4";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 4) 
       {

        GameObject Operacion = Instantiate(_Operacion4);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "1/2";
        _TextoRespuesta2.text = "-1/2"; // correcto
        _TextoRespuesta3.text = "4/3";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 5) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion5);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "90/53";
        _TextoRespuesta2.text = "6/10"; 
        _TextoRespuesta3.text = "53/30"; // correcto

         respuestaCorrecta = 3;

       } else if (escojerOperacion == 6) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion6);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "29/30"; // correcto
        _TextoRespuesta2.text = "47/60"; 
        _TextoRespuesta3.text = "10/15";

        respuestaCorrecta = 1;
       
       } else if (escojerOperacion == 7) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion7);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "16/15"; // correcto
        _TextoRespuesta2.text = "4/8"; 
        _TextoRespuesta3.text = "15/5";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 10) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion10);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "10/11";
        _TextoRespuesta2.text = "46/15"; // correcto
        _TextoRespuesta3.text = "21/15";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 11) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion11);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 5;

        _TextoRespuesta1.text = "11/12"; // correcto
        _TextoRespuesta2.text = "4/10"; 
        _TextoRespuesta3.text = "10/11";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 13) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion13);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 7;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "1/3"; // correcto
        _TextoRespuesta2.text = "1"; 
        _TextoRespuesta3.text = "1/1";

        respuestaCorrecta = 1;

       } else if (escojerOperacion == 16) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion16);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 6;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "5/17";
        _TextoRespuesta2.text = "9/5"; // correcto
        _TextoRespuesta3.text = "4/2";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 17) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion17);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "4/4";
        _TextoRespuesta2.text = "-4/3"; 
        _TextoRespuesta3.text = "7/3"; // correcto

         respuestaCorrecta = 3;

       } else if (escojerOperacion == 18) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion18);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 7;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "33/12";
        _TextoRespuesta2.text = "11/4"; // correcto
        _TextoRespuesta3.text = "8/11";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 20) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion20);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 5;
        _TextoRespuesta2.fontSize = 5;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "-22/12";
        _TextoRespuesta2.text = "-37/18"; // correcto
        _TextoRespuesta3.text = "-8/18";

        respuestaCorrecta = 2;

       } else if (escojerOperacion == 29) 
       {    
        
        GameObject Operacion = Instantiate(_Operacion29);
        Operacion.transform.position = _posicionPizarraOperacionSpawn.transform.position;
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
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
        Operacion.transform.parent = GameObject.Find("ArbolMatematico").transform;
        Operacion.tag = "Operacion";
     
        _TextoRespuesta1.fontSize = 6;
        _TextoRespuesta2.fontSize = 7;
        _TextoRespuesta3.fontSize = 6;

        _TextoRespuesta1.text = "13/6"; // correcto
        _TextoRespuesta2.text = "6/13"; 
        _TextoRespuesta3.text = "-13/6";

        respuestaCorrecta = 1;

       } 

    } 

}
