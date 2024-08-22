using System.Collections;

namespace Fibonacci
{
	/// <summary>
	/// Последовательность чисел Фибоначчи.
	/// </summary>
	internal class Sequence : IEnumerator<int>, IEnumerable<int>
	{
		private readonly int _count;
		private int _index;

		private Number _current;

		internal Sequence(int count)
		{
			_count = count;

			Reset();
		}

		/// <summary>
		/// Значение текущего элемента в последовательности.
		/// </summary>
		public int Current => _current.Value;

		/// <summary>
		/// Значение текущего элемента в последовательности.
		/// </summary>
		object IEnumerator.Current => Current;

		public void Dispose() { }

		/// <summary>
		/// Сгенерировать следующий элемент последовательности.
		/// </summary>
		/// <returns>
		///		<c>false</c>, если достигнут конец последовательности,
		///		<c>true</c>, если последовательность продолжается.
		/// </returns>
		public bool MoveNext()
		{
			if (_index + 1 == _count)
			{
				return false;
			}

			_current = _current.Next;

			_index++;

			return true;
		}

		/// <summary>
		/// Вернуться к началу последовательности.
		/// </summary>
		public void Reset()
		{
			_index = -1;
			_current = new Number();
		}

		/// <summary>
		/// Получить итератор последовательности Фибоначчи.
		/// </summary>
		/// <returns>Итератор последовательности Фибоначчи.</returns>
		public IEnumerator<int> GetEnumerator() => this;

		/// <summary>
		/// Получить итератор последовательности Фибоначчи.
		/// </summary>
		/// <returns>Итератор последовательности Фибоначчи.</returns>
		IEnumerator IEnumerable.GetEnumerator() => this;
	}
}
