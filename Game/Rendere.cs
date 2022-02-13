using winForm;

namespace Render
{
    class Rendere
    {
        public bool isRunning = false;
        private Form1 _form;
        public Rendere(Form1 form)
        {
            _form = form;
        }

        public void Play()
        {
            isRunning = true;
        }

        private void Render()
        {
            for (int row = -(_form.Height >> 1); row < (_form.Height >> 1); row++)
            {
                for (int colum = -(_form.Height >> 1); colum < (_form.Width >> 1); colum++)
                {
                    
                }
            }
        }

        public void Stop()
        {
            isRunning = false;
        }
    }
}