using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using prep.utility.searching;

namespace prep.specs
{
  public class NegatingMatchSpecs
  {
      public abstract class concern : Observes<NegatingMatch<AnynomousItem>>
      {
      }

      public class when_matches_true_return_false : concern
      {
          Establish c = () =>
          {
              match_to_negate = depends.on<IMatchA<AnynomousItem>>();
              dummyItem = fake.an<AnynomousItem>();
              match_to_negate.setup(x => x.matches(dummyItem)).Return(isMatched);
          };


          private Because b = () => result = sut.matches(dummyItem);

          It should_return_false = () =>
            result.ShouldEqual(!isMatched);

          static IMatchA<AnynomousItem> match_to_negate;
          static bool result;
          static AnynomousItem dummyItem;
          static bool isMatched = true;

      }

      public class when_matches_false_return_true : concern
      {
          Establish c = () =>
          {
              match_to_negate = depends.on<IMatchA<AnynomousItem>>();
              dummyItem = fake.an<AnynomousItem>();
              match_to_negate.setup(x => x.matches(dummyItem)).Return(isMatched);
          };


          private Because b = () => result = sut.matches(dummyItem);

          It should_return_true = () =>
            result.ShouldEqual(!isMatched);

          static IMatchA<AnynomousItem> match_to_negate;
          static bool result;
          static AnynomousItem dummyItem;
          static bool isMatched = true;

      }

  }

  public class AnynomousItem
  {
  }
}