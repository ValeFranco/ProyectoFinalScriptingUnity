using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;

public class TestPierdeVida
{
    string nombreEscena = "DoesPlayerLoseLife";

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene(nombreEscena);
    }

    [UnityTest]
    public IEnumerator TestPierdeVidaWithEnumeratorPasses()
    {
        GameObject player;
        player = GameObject.FindGameObjectWithTag("Player");
        Assert.IsNotNull(player);

        int playerOriginalLife = (int)player.GetComponent<ControlJugador>().jugador.vidas;

        yield return new WaitForSeconds(1f);

        player.transform.position = new Vector2(1.4f, -3.1f);

        yield return new WaitForSeconds(1f);

        Assert.Greater(player.GetComponent<ControlJugador>().jugador.poder, playerOriginalLife);
    }
        public void Teardown()
        {
            EditorSceneManager.UnloadSceneAsync(nombreEscena);
        }
    
}
