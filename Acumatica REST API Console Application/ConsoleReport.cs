using System;
using System.Collections.Generic;
using System.Diagnostics;

using Acumatica.RESTClient.Client;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;

namespace AcumaticaRestApiExample
{
	/// <summary>
	/// The console output shared by all of the examples: a uniform heading and Pass/Failed line
	/// for each one, and a summary of everything that ran.
	/// </summary>
	internal static class ConsoleReport
	{
		private const string Separator = "----------------------------------------";
		private const string PassLabel = "Pass  ";
		private const string FailLabel = "Failed";

		/// <summary>How much of a failure message the summary repeats before trimming it.</summary>
		private const int SummaryErrorWidth = 100;

		private static readonly List<ExampleResult> Results = new List<ExampleResult>();

		private sealed class ExampleResult
		{
			public ExampleResult(string name, string error, TimeSpan duration)
			{
				Name = name;
				Error = error;
				Duration = duration;
			}

			public string Name { get; }

			/// <summary><c>null</c> when the example succeeded.</summary>
			public string? Error { get; }

			public TimeSpan Duration { get; }

			public bool Passed
			{
				get { return Error == null; }
			}
		}

		/// <summary>
		/// Runs one example under a uniform heading, reports whether it passed, and records the
		/// outcome for <see cref="PrintSummary"/>. An example signals failure by letting an
		/// exception escape, so examples must not swallow their own errors.
		/// </summary>
		public static void Run(string name, Action example)
		{
			Console.WriteLine();
			Console.WriteLine(Separator);
			Console.WriteLine(name);

			string? error = null;
			Stopwatch stopwatch = Stopwatch.StartNew();
			try
			{
				example();
			}
			catch (Exception e)
			{
				error = e.GetType().Name + ": " + e.Message;
			}
			stopwatch.Stop();

			Results.Add(new ExampleResult(name, error!, stopwatch.Elapsed));

			Console.WriteLine();
			if (error == null)
			{
				WriteInColor(PassLabel, ConsoleColor.Green);
				Console.WriteLine("  " + FormatDuration(stopwatch.Elapsed));
			}
			else
			{
				WriteInColor(FailLabel, ConsoleColor.Red);
				Console.WriteLine("  " + FormatDuration(stopwatch.Elapsed));
				// The whole message here, because this is where it is useful. The summary
				// shortens it so that the list stays readable.
				Console.WriteLine(error);
			}
		}

		/// <summary>
		/// Logs the client out and reports the outcome the same way everywhere. Examples call this
		/// from a finally block, because the session has to be released even when the example failed.
		/// </summary>
		public static void Logout(ApiClient client)
		{
			if (client.TryLogout())
			{
				Console.WriteLine("Logged out successfully.");
			}
			else
			{
				Console.WriteLine("An error occured during logout.");
			}
		}

		/// <summary>Waits for the user before moving on to the next group of examples.</summary>
		public static void Pause()
		{
			Console.WriteLine();
			Console.WriteLine("Ready to continue...");
			Console.ReadLine();
		}

		/// <summary>Lists every example that ran, with its result.</summary>
		public static void PrintSummary()
		{
			Console.WriteLine();
			Console.WriteLine("Summary");
			Console.WriteLine(Separator);

			if (Results.Count == 0)
			{
				Console.WriteLine("No examples were run.");
				return;
			}

			int nameWidth = 0;
			foreach (ExampleResult result in Results)
			{
				if (result.Name.Length > nameWidth)
				{
					nameWidth = result.Name.Length;
				}
			}

			int passed = 0;
			foreach (ExampleResult result in Results)
			{
				if (result.Passed)
				{
					passed++;
					WriteInColor(PassLabel, ConsoleColor.Green);
				}
				else
				{
					WriteInColor(FailLabel, ConsoleColor.Red);
				}

				Console.WriteLine("  " + result.Name.PadRight(nameWidth) + "  " + FormatDuration(result.Duration));

				if (!result.Passed)
				{
					Console.WriteLine(new string(' ', FailLabel.Length + 2) + Shorten(result.Error!));
				}
			}

			Console.WriteLine(Separator);

			int failed = Results.Count - passed;
			Console.Write(Results.Count + " example(s): ");
			WriteInColor(passed + " passed", ConsoleColor.Green);
			if (failed > 0)
			{
				Console.Write(", ");
				WriteInColor(failed + " failed", ConsoleColor.Red);
			}
			Console.WriteLine();
		}

		/// <summary>Collapses a message onto one line so that the summary list stays aligned.</summary>
		private static string Shorten(string message)
		{
			string singleLine = message.Replace("\r", " ").Replace("\n", " ").Trim();
			while (singleLine.Contains("  "))
			{
				singleLine = singleLine.Replace("  ", " ");
			}

			return singleLine.Length <= SummaryErrorWidth
				? singleLine
				: singleLine.Substring(0, SummaryErrorWidth - 3) + "...";
		}

		private static string FormatDuration(TimeSpan duration)
		{
			return "(" + duration.TotalSeconds.ToString("0.00") + "s)";
		}

		private static void WriteInColor(string text, ConsoleColor color)
		{
			ConsoleColor previous = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.Write(text);
			Console.ForegroundColor = previous;
		}
	}
}
