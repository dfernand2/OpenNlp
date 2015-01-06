﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenNLP.Tools.Util.Ling;

namespace OpenNLP.Tools.Util.Trees
{
    /**
 * A <code>Constituent</code> object defines a generic edge in a graph.
 * The <code>Constituent</code> class is designed to be extended.  It
 * implements the <code>Comparable</code> interface in order to allow
 * graphs to be topologically sorted by the ordinary <code>Collection</code>
 * library in <code>java.util</code>, keying primarily on right-hand
 * node ID number.  The <code>Constituent</code> class implements most
 * of the functionality of the the <code>Label</code>
 * interface by passing all requests down to the <code>Label</code> which
 * might be contained in the <code>Constituent</code>.  This allows one
 * to put a <code>Constituent</code> anywhere that a <code>Label</code> is
 * required.  A <code>Constituent</code> is always <code>Scored</code>.
 *
 * @author Christopher Manning
 */

    public abstract class Constituent : Labeled, Scored, Label
    {
        public Constituent()
        {
        }

        /**
   * access start node.
   */
        public abstract int start();

        /**
   * set start node.
   */
        public abstract void setStart(int start);


        /**
   * access end node.
   */
        public abstract int end();


        /**
   * set end node.
   */
        public abstract void setEnd(int end);


        /**
   * access label
   */

        public Label label()
        {
            return null;
        }


        /**
   * Sets the label associated with the current Constituent,
   * if there is one.
   */

        public void setLabel(Label label)
        {
            // a noop
        }


        /**
   * Access labels -- actually always a singleton here.
   */

        public ICollection<Label> labels()
        {
            return new List<Label>() {label()};
        }


        public void setLabels(ICollection<Label> labels)
        {
            throw new InvalidOperationException("Constituent can't be multilabeled");
        }


        /**
   * access score
   */

        public double score()
        {
            return Double.NaN;
        }


        /**
   * Sets the score associated with the current node, if there is one
   */

        public void setScore(double score)
        {
            // a no-op
        }


        /**
   * Return a string representation of a <code>Constituent</code>.
   *
   * @return The full string representation.
   */
        //@Override
        public override string ToString()
        {
            StringBuilder sb;
            Label lab = label();
            if (lab != null)
            {
                sb = new StringBuilder(lab.ToString());
            }
            else
            {
                sb = new StringBuilder();
            }
            sb.Append("(").Append(start()).Append(",").Append(end()).Append(")");
            return sb.ToString();
        }


        /**
   * Return the length of a <code>Constituent</code>
   */

        public int size()
        {
            return end() - start();
        }


        /**
   * Compare with another Object for equality.
   * Two Constituent objects are equal if they have the same start and end,
   * and, if at least one of them has a non-null label, then their labels are equal.
   * The score of a Constituent is not considered in the equality test.
   * This seems to make sense for most of the applications we have in mind
   * where one wants to assess equality independent of score, and then if
   * necessary to relax a constituent if one with a better score is found.
   * (Note, however, that if you do want to compare Constituent scores for
   * equality, then you have to be careful,
   * because two <code>double</code> NaN values are considered unequal in
   * Java.)
   * The general contract of equals() implies that one can't have a
   * subclass of a concrete [non-abstract] class redefine equals() to use
   * extra aspects, so subclasses shouldn't override this in ways that
   * make use of extra fields.
   *
   * @param obj The object being compared with
   * @return true if the objects are equal
   */
        //@Override
        public override bool Equals(Object obj)
        {
            // unclear if this will be a speedup in general
            // if (this == o)
            //      return true;
            if (obj is Constituent)
            {
                Constituent c = (Constituent) obj;
                // System.out.println("Comparing " + this + " to " + c + "\n  " +
                //	"start: " + (start() == c.start()) + " end: " +
                //	(end() == c.end()) + " score: " + (score() == c.score()));
                if ((start() == c.start()) && (end() == c.end()))
                {
                    Label lab1 = label();
                    Label lab2 = c.label();
                    if (lab1 == null)
                    {
                        return lab2 == null;
                    }

                    string lv1 = lab1.value();
                    string lv2 = lab2.value();
                    if (lv1 == null && lv2 == null)
                    {
                        return true;
                    }
                    if (lv1 != null && lv2 != null)
                    {
                        return lab1.value().Equals(lab2.value());
                    }
                }
            }
            return false;
        }


        /**
   * A hashCode for Constituents done by shifting and or'ing for speed.
   * Now includes the label if the constituent has one (otherwise things
   * would work very badly if you were hashing constituents over the
   * same span....).
   *
   * @return the integer hashCode
   */
        //@Override
        public override int GetHashCode()
        {
            int hash = (start() << 16) | end();
            Label lab = label();
            return (lab == null || lab.value() == null) ? hash : hash ^ lab.value().GetHashCode();
        }


        /**
   * Detects whether this constituent overlaps a constituent without
   * nesting, that is, whether they "cross".
   *
   * @param c The constituent to check against
   * @return True if the two constituents cross
   */

        public bool crosses(Constituent c)
        {
            return (start() < c.start() && c.start() < end() && end() < c.end()) ||
                   (c.start() < start() && start() < c.end() && c.end() < end());
        }


        /**
   * Detects whether this constituent overlaps any of a Collection of
   * Constituents without
   * nesting, that is, whether it "crosses" any of them.
   *
   * @param constColl The set of constituent to check against
   * @return True if some constituent in the collection is crossed
   * @throws ClassCastException If some member of the Collection isn't
   *                            a Constituent
   */

        public bool crosses(ICollection<Constituent> constColl)
        {
            foreach (Constituent c in constColl)
            {
                if (crosses(c))
                {
                    return true;
                }
            }
            return false;
        }


        /**
   * Detects whether this constituent contains a constituent, that is
   * whether they are nested.  That is, the other constituent's yield is
   * a sublist of this constituent's yield.
   *
   * @param c The constituent to check against
   * @return True if the other Constituent is contained in this one
   */

        public bool contains(Constituent c)
        {
            return start() <= c.start() && end() >= c.end();
        }



        // -- below here is stuff to implement the Label interface

        /**
   * Return the value of the label (or null if none).
   *
   * @return string the value for the label
   */

        public string value()
        {
            Label lab = label();
            if (lab == null)
            {
                return null;
            }
            return lab.value();
        }


        /**
   * Set the value for the label (if one is stored).
   *
   * @param value The value for the label
   */

        public void setValue(string value)
        {
            Label lab = label();
            if (lab != null)
            {
                lab.setValue(value);
            }
        }


        /**
   * Make a new label with this <code>string</code> as the "name", perhaps
   * by doing some appropriate decoding of the string.
   *
   * @param labelStr the string that translates into the content of the
   *                 label
   */

        public void setFromString(string labelStr)
        {
            Label lab = label();
            if (lab != null)
            {
                lab.setFromString(labelStr);
            }
        }

        public abstract LabelFactory labelFactory();


        /**
   * Print out as a string the subpart of a sentence covered
   * by this <code>Constituent</code>.
   *
   * @return The subpart of the sentence
   */
        // TODO: genericize this!
        public string toSentenceString(List<string> s)
        {
            StringBuilder sb = new StringBuilder();
            for (int wordNum = start(), vEnd = end(); wordNum <= vEnd; wordNum++)
            {
                sb.Append(s[wordNum]);
                if (wordNum != vEnd)
                {
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }
    }
}