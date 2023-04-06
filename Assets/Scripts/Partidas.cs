using System;
using UnityEngine.TestTools;
using UnityEngine;
using UnityEngine.UI;

namespace Tests
{
    public class Partidas : MonoBehaviour
    {
        [SerializeField] private Text[] listaDePuntos;

        private bool isStrike = false;

        [ContextMenu("Partida")]
        public void ASDASDAS()
        {
            for (int i = 0; i < 100; i++)
            {
                Debug.Log(Partida());
            }
        }

        public int Partida()
        {
            int puntajePartida = 0;
            int cantTurnos = 10;

            for (int i = 0; i < cantTurnos; i++)
            {
                int ultimoPuntajeTurno = Turno();

                if (i == cantTurnos - 1 && ultimoPuntajeTurno == 10 && isStrike) //si en el ulimo turno es trike
                {
                    int tiroExtra = Turno();
                    if (isStrike)
                    {
                        tiroExtra += Turno();
                    }
                    puntajePartida = tiroExtra;
                }
                else
                    puntajePartida += Turno();

                puntajePartida += ultimoPuntajeTurno;
            }
            Debug.Log(puntajePartida);
            return puntajePartida;
        }

        public int Turno()
        {
            isStrike = false;
            int puntaje = 0;
            int bolos = 0;

            for (int i = 0; i < 2; i++) // 2 = cantidad de lanzamientos por turno
            {
                bolos = Lanzamiento(bolos);
                puntaje += bolos;

                if (puntaje % 10 == 0 && puntaje > 0 && i == 0)
                {
                    isStrike = true;
                    return puntaje; //Strike
                }
                else
                    return puntaje; //Spare
            }
            return puntaje;
        }
        public int Lanzamiento(int min)
        {
            return 10 - UnityEngine.Random.Range(min, 11);
        }
    }
}