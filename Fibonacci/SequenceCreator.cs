namespace Fibonacci
{
	/// <summary>
	/// Средство создания последовательности Фибоначчи.
	/// </summary>
	internal static class SequenceCreator
	{
		/// <summary>
		/// Создать последовательность Фибоначчи.
		/// </summary>
		/// <param name="count">Кол-во элементов в последовательности.</param>
		/// <returns>Последовательность чисел Фибоначчи.</returns>
		internal static IEnumerable<int> Create(int count)
		{
			var current = new Number();
			for (int i = 0; i < count; i++)
			{
				current = current.Next;

				yield return current.Value;
			}
		}
	}
}
