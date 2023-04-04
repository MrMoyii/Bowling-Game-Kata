﻿using System;
using UnityEngine.TestTools;
using UnityEngine;
using UnityEngine.UI;

namespace Tests
{
    public class Partidas : MonoBehaviour
    {
        [SerializeField] private Text[] listaDePuntos;

        [ContextMenu("Partida")]
        public void Partida()
        {
            int turnos = 10;
            int tiradas = 2;

            int puntuacionDeTurnos = 0;
            bool strike = false;

            int total = 0;

            for (int i = 0; i < turnos; i++)
            {
                if (strike)
                {
                    puntuacionDeTurnos = 10;
                    strike = false;
                }
                else puntuacionDeTurnos = 0;

                int bolosRestantes = 0;

                if(i == 9)
                {
                    for (int j = 0; j < tiradas; j++)
                    {
                        puntuacionDeTurnos += UnityEngine.Random.Range(bolosRestantes, 10);
                        bolosRestantes = puntuacionDeTurnos;
                        //Spare
                        if (puntuacionDeTurnos == 10)
                        {
                            puntuacionDeTurnos += UnityEngine.Random.Range(0, 10);
                            break;
                        }
                        //Strike
                        if (j == 0 && puntuacionDeTurnos == 10)
                        {
                            puntuacionDeTurnos += UnityEngine.Random.Range(0, 10);
                            
                            if(puntuacionDeTurnos != 10) bolosRestantes = puntuacionDeTurnos;

                            puntuacionDeTurnos += UnityEngine.Random.Range(bolosRestantes, 10);
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < tiradas; j++)
                    {
                        puntuacionDeTurnos += UnityEngine.Random.Range(bolosRestantes, 10);
                        bolosRestantes = puntuacionDeTurnos;
                        if (puntuacionDeTurnos == 10)
                        {
                            puntuacionDeTurnos += UnityEngine.Random.Range(0, 10);
                            break;
                        }
                        if (j == 0 && puntuacionDeTurnos == 10)
                        {
                            //si hace "strike"
                            strike = true;
                            break;
                        }
                    }
                }
                total += puntuacionDeTurnos;
                listaDePuntos[i].text = puntuacionDeTurnos.ToString();
                Debug.Log(puntuacionDeTurnos);
            }
            listaDePuntos[turnos].text = total.ToString();
        }
    }
}