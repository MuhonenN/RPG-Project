using UnityEngine;

namespace RPG.Core {

    public class AudioRandomizer : MonoBehaviour {

        [SerializeField] AudioClip[] audioClips = null;

        private AudioSource audioSource = null;

        public void PlayRandomAudioClip() {
            if (audioClips != null) {
                int index = UnityEngine.Random.Range(0, audioClips.Length);
                var randomClip = audioClips[index];
                audioSource.PlayOneShot(randomClip);
            }
        }

        private void Start() {
            audioSource = GetComponent<AudioSource>();
        }                    
    }    
}