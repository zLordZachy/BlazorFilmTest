
namespace BlazorFilmTest.ViewModel
{
    public class CounterViewModel
    {

        public int CurrentCount { get; set; }

        public CounterViewModel()
        {
            CurrentCount = 0;
        }

        public void IncrementCount()
        {
            CurrentCount++;
        }

    }
}
