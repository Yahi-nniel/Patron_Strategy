﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstrategy
{
    internal interface IEstrategia
    {
        void CalcularTime();
    }
}



//APLIQUE EL PATRON STRATEGY EN EL SIGUIENTE ESCENARIO.

//UN PASEADOR DE MASCOTAS PASEA UNA MASCOTA A LA VEZ. SEGÚN LA RAZA, EL PASEO PUEDE DURAR MAS O MENOS TIEMPO. Y EL COSTO DEL PASEO SERA DIFERENTE

//CHIHUAHUA: 20 MINUTOS.COSTO: RD$100

//LABRADOR: 40 MINUTOS.COSTO: RD$200

//HUSKY SIBERIANO: 60 MINUTOS.COSTO: RD$300

//CUANDO AL PASEADOR LE DIGAN QUE RAZA DE PERRO ES, EL PROGRAMA DEBE PRESENTAR UN MENSAJE CON EL TIEMPO DEL PASEO Y EL COSTO.