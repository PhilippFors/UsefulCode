using Data.Utility;

namespace Data
{
    [System.Serializable]
    public class SceneReference : BaseReference<SceneInfo, SceneVariable>
    {
        public SceneReference()
        {
        }

        public SceneReference(SceneInfo value) : base(value)
        {
        }
    }
}