using System;
using UnityEngine.TestTools;
using UnityEngine;
using UnityEngine.UI;

namespace Tests
{
    public class Partidas : MonoBehaviour
    {
        [SerializeField] private Text[] listaDePuntos;

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

            for (int i = 0; i < 10; i++)
            {
                //if (i == cantTurnos - 1)
                //{
                //    ultimoPuntajeTurno = Turno(ultimoPuntajeTurno, true);
                //    puntajePartida += ultimoPuntajeTurno;
                //    return puntajePartida;
                //}
                puntajePartida += Turno();
            }
            Debug.Log(puntajePartida);
            return puntajePartida;
        }

        public int Turno()
        {
            int puntaje = 0;
            int bolos = 0;

            for (int i = 0; i < 2; i++)
            {
                bolos = Lanzamiento(bolos);
                puntaje += bolos;
                if (bolos % 10 == 0 && bolos > 0) return puntaje; //Strike or Spare
            }
            return puntaje;
        }
        public int Lanzamiento(int min)
        {
            return 10 - UnityEngine.Random.Range(min, 11);
        }
    }
}