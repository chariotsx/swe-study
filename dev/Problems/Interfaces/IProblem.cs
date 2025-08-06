namespace Problems.Interfaces
{
    public interface IProblem<TInput, TOutput>
    {
        string ProblemName { get; }
        string URL { get; }
        string AdditionalNotes { get; }

        TOutput Solve(TInput input);
    }
}