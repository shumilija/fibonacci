namespace Fibonacci
{
	/// <summary>
	/// Тестирование расчета чисел Фибоначчи.
	/// </summary>
	public class Test
	{
		private static readonly int[] Sample =
		{
			0, 1, 1, 2, 3, 5, 8, 13, 21,
		};

		/// <summary>
		/// Протестировать последовательность, реализованную через IEnumerable/IEnumerator.
		/// </summary>
		/// <param name="count">Кол-во элементов в последовательности.</param>
		[Theory]
		[InlineData(7)]
		[InlineData(9)]
		internal void TestSequence(int count)
		{
			var sequence = new Sequence(count);

			int i = 0;
			foreach (var item in sequence)
			{
				Assert.Equal(Sample[i], item);

				i++;
			}
		}

		/// <summary>
		/// Протестировать последовательность, реализованную через yield.
		/// </summary>
		/// <param name="count"></param>
		[Theory]
		[InlineData(7)]
		[InlineData(9)]
		internal void TestSequenceCreator(int count)
		{
			var sequence = SequenceCreator.Create(count);

			int i = 0;
			foreach (var item in sequence)
			{
				Assert.Equal(Sample[i], item);

				i++;
			}
		}
	}
}
