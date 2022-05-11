using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;

public class TestGanaContraObstaculo
{
    string nombreEscena = "GanarContraObstaculo";

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene(nombreEscena);
    }
    [UnityTest]
    public IEnumerator TestGanaContraObstaculoWithEnumeratorPasses()
    {
        GameObject player;
        player = GameObject.FindGameObjectWithTag("Player");
        Assert.IsNotNull(player);

        int playerOriginalPower = (int)player.GetComponent<ControlJugador>().jugador.poder;

        yield return new WaitForSeconds(1f);

        player.transform.position = new Vector2(-5.5f, -0.11f);

        yield return new WaitForSeconds(1f);

        Assert.Greater(player.GetComponent<ControlJugador>().jugador.poder, playerOriginalPower);
    }
    public void Teardown()
    {
        EditorSceneManager.UnloadSceneAsync(nombreEscena);
    }
}
    

