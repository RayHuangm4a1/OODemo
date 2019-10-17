using System;

namespace OODemo.APIFetcher
{
    public interface IAction
    {
        string Get();

        string Post();

        string Put();

        string Delete();

    }
}
