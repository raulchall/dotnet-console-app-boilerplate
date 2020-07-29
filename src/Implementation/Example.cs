using System.Text;

namespace practice.Implementation {

    /// <summary>
    /// A representation of an example class
    /// </summary>
    public interface IExample {

        /// <summary>
        /// Reverts the target string
        /// </summary>
        /// <param name="target">A string to be reversed</param>
        /// <returns>A new string with the reverse of the target string</returns>
        string Revert (string target);
    }

    /// <summary>
    /// An example implementation of <see cref="IExample"/>
    /// </summary>
    public class Example : IExample {

        /// <inheritdoc cref="IExample.Revert"/>
        public string Revert (string target) {
            if (string.IsNullOrEmpty (target)) {
                return target;
            }

            var sb = new StringBuilder ();
            for (int i = target.Length - 1; i >= 0; i--) {
                sb.Append (target[i]);
            }

            return sb.ToString ();
        }
    }
}