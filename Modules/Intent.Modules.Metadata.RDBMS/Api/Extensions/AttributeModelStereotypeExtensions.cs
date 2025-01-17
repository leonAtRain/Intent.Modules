using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modelers.Domain.Api;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;
using Intent.SdkEvolutionHelpers;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModelExtensions", Version = "1.0")]

namespace Intent.Metadata.RDBMS.Api
{
    public static class AttributeModelStereotypeExtensions
    {
        public static Column GetColumn(this AttributeModel model)
        {
            var stereotype = model.GetStereotype("Column");
            return stereotype != null ? new Column(stereotype) : null;
        }

        /// <summary>
        /// Obsolete. Use <see cref="GetColumn"/> instead.
        /// </summary>
        [Obsolete(WillBeRemovedIn.Version4)]
        [IntentManaged(Mode.Ignore)]
        public static IReadOnlyCollection<Column> GetColumns(this AttributeModel model)
        {
            var stereotypes = model
                .GetStereotypes("Column")
                .Select(stereotype => new Column(stereotype))
                .ToArray();

            return stereotypes;
        }

        public static bool HasColumn(this AttributeModel model)
        {
            return model.HasStereotype("Column");
        }

        public static bool TryGetColumn(this AttributeModel model, out Column stereotype)
        {
            if (!HasColumn(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new Column(model.GetStereotype("Column"));
            return true;
        }

        public static ComputedValue GetComputedValue(this AttributeModel model)
        {
            var stereotype = model.GetStereotype("Computed Value");
            return stereotype != null ? new ComputedValue(stereotype) : null;
        }

        /// <summary>
        /// Obsolete. Use <see cref="GetComputedValue"/> instead.
        /// </summary>
        [Obsolete(WillBeRemovedIn.Version4)]
        [IntentManaged(Mode.Ignore)]
        public static IReadOnlyCollection<ComputedValue> GetComputedValues(this AttributeModel model)
        {
            var stereotypes = model
                .GetStereotypes("Computed Value")
                .Select(stereotype => new ComputedValue(stereotype))
                .ToArray();

            return stereotypes;
        }

        public static bool HasComputedValue(this AttributeModel model)
        {
            return model.HasStereotype("Computed Value");
        }

        public static bool TryGetComputedValue(this AttributeModel model, out ComputedValue stereotype)
        {
            if (!HasComputedValue(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new ComputedValue(model.GetStereotype("Computed Value"));
            return true;
        }

        public static DecimalConstraints GetDecimalConstraints(this AttributeModel model)
        {
            var stereotype = model.GetStereotype("Decimal Constraints");
            return stereotype != null ? new DecimalConstraints(stereotype) : null;
        }

        public static bool HasDecimalConstraints(this AttributeModel model)
        {
            return model.HasStereotype("Decimal Constraints");
        }

        public static bool TryGetDecimalConstraints(this AttributeModel model, out DecimalConstraints stereotype)
        {
            if (!HasDecimalConstraints(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new DecimalConstraints(model.GetStereotype("Decimal Constraints"));
            return true;
        }

        public static DefaultConstraint GetDefaultConstraint(this AttributeModel model)
        {
            var stereotype = model.GetStereotype("Default Constraint");
            return stereotype != null ? new DefaultConstraint(stereotype) : null;
        }

        /// <summary>
        /// Obsolete. Use <see cref="GetDefaultConstraint"/> instead.
        /// </summary>
        [Obsolete(WillBeRemovedIn.Version4)]
        [IntentManaged(Mode.Ignore)]
        public static IReadOnlyCollection<DefaultConstraint> GetDefaultConstraints(this AttributeModel model)
        {
            var stereotypes = model
                .GetStereotypes("Default Constraint")
                .Select(stereotype => new DefaultConstraint(stereotype))
                .ToArray();

            return stereotypes;
        }

        public static bool HasDefaultConstraint(this AttributeModel model)
        {
            return model.HasStereotype("Default Constraint");
        }

        public static bool TryGetDefaultConstraint(this AttributeModel model, out DefaultConstraint stereotype)
        {
            if (!HasDefaultConstraint(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new DefaultConstraint(model.GetStereotype("Default Constraint"));
            return true;
        }

        public static ForeignKey GetForeignKey(this AttributeModel model)
        {
            var stereotype = model.GetStereotype("Foreign Key");
            return stereotype != null ? new ForeignKey(stereotype) : null;
        }

        /// <summary>
        /// Obsolete. Use <see cref="GetForeignKey"/> instead.
        /// </summary>
        [Obsolete(WillBeRemovedIn.Version4)]
        [IntentManaged(Mode.Ignore)]
        public static IReadOnlyCollection<ForeignKey> GetForeignKeys(this AttributeModel model)
        {
            var stereotypes = model
                .GetStereotypes("Foreign Key")
                .Select(stereotype => new ForeignKey(stereotype))
                .ToArray();

            return stereotypes;
        }

        public static bool HasForeignKey(this AttributeModel model)
        {
            return model.HasStereotype("Foreign Key");
        }

        public static bool TryGetForeignKey(this AttributeModel model, out ForeignKey stereotype)
        {
            if (!HasForeignKey(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new ForeignKey(model.GetStereotype("Foreign Key"));
            return true;
        }

        public static Index GetIndex(this AttributeModel model)
        {
            var stereotype = model.GetStereotype("Index");
            return stereotype != null ? new Index(stereotype) : null;
        }

        public static IReadOnlyCollection<Index> GetIndices(this AttributeModel model)
        {
            var stereotypes = model
                .GetStereotypes("Index")
                .Select(stereotype => new Index(stereotype))
                .ToArray();

            return stereotypes;
        }

        public static bool HasIndex(this AttributeModel model)
        {
            return model.HasStereotype("Index");
        }

        public static bool TryGetIndex(this AttributeModel model, out Index stereotype)
        {
            if (!HasIndex(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new Index(model.GetStereotype("Index"));
            return true;
        }

        public static PrimaryKey GetPrimaryKey(this AttributeModel model)
        {
            var stereotype = model.GetStereotype("Primary Key");
            return stereotype != null ? new PrimaryKey(stereotype) : null;
        }

        /// <summary>
        /// Obsolete. Use <see cref="GetPrimaryKey"/> instead.
        /// </summary>
        [Obsolete(WillBeRemovedIn.Version4)]
        [IntentManaged(Mode.Ignore)]
        public static IReadOnlyCollection<PrimaryKey> GetPrimaryKeys(this AttributeModel model)
        {
            var stereotypes = model
                .GetStereotypes("Primary Key")
                .Select(stereotype => new PrimaryKey(stereotype))
                .ToArray();

            return stereotypes;
        }

        public static bool HasPrimaryKey(this AttributeModel model)
        {
            return model.HasStereotype("Primary Key");
        }

        public static bool TryGetPrimaryKey(this AttributeModel model, out PrimaryKey stereotype)
        {
            if (!HasPrimaryKey(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new PrimaryKey(model.GetStereotype("Primary Key"));
            return true;
        }

        public static TextConstraints GetTextConstraints(this AttributeModel model)
        {
            var stereotype = model.GetStereotype("Text Constraints");
            return stereotype != null ? new TextConstraints(stereotype) : null;
        }

        /// <summary>
        /// Obsolete. Use <see cref="GetTextConstraints"/> instead.
        /// </summary>
        [Obsolete(WillBeRemovedIn.Version4)]
        [IntentManaged(Mode.Ignore)]
        public static IReadOnlyCollection<TextConstraints> GetTextConstraintss(this AttributeModel model)
        {
            var stereotypes = model
                .GetStereotypes("Text Constraints")
                .Select(stereotype => new TextConstraints(stereotype))
                .ToArray();

            return stereotypes;
        }

        public static bool HasTextConstraints(this AttributeModel model)
        {
            return model.HasStereotype("Text Constraints");
        }

        public static bool TryGetTextConstraints(this AttributeModel model, out TextConstraints stereotype)
        {
            if (!HasTextConstraints(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new TextConstraints(model.GetStereotype("Text Constraints"));
            return true;
        }

        public class Column
        {
            private IStereotype _stereotype;

            public Column(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string StereotypeName => _stereotype.Name;

            public string Name()
            {
                return _stereotype.GetProperty<string>("Name");
            }

            public string Type()
            {
                return _stereotype.GetProperty<string>("Type");
            }

        }

        public class ComputedValue
        {
            private IStereotype _stereotype;

            public ComputedValue(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public string SQL()
            {
                return _stereotype.GetProperty<string>("SQL");
            }

            public bool Stored()
            {
                return _stereotype.GetProperty<bool>("Stored");
            }

        }

        public class DecimalConstraints
        {
            private IStereotype _stereotype;

            public DecimalConstraints(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public int? Precision()
            {
                return _stereotype.GetProperty<int?>("Precision");
            }

            public int? Scale()
            {
                return _stereotype.GetProperty<int?>("Scale");
            }

        }

        public class DefaultConstraint
        {
            private IStereotype _stereotype;

            public DefaultConstraint(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public string Value()
            {
                return _stereotype.GetProperty<string>("Value");
            }

            public bool TreatAsSQLExpression()
            {
                return _stereotype.GetProperty<bool>("Treat as SQL Expression");
            }

        }

        public class ForeignKey
        {
            private IStereotype _stereotype;

            public ForeignKey(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public IElement Association()
            {
                return _stereotype.GetProperty<IElement>("Association");
            }

        }

        public class Index
        {
            private IStereotype _stereotype;

            public Index(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public string UniqueKey()
            {
                return _stereotype.GetProperty<string>("UniqueKey");
            }

            public int? Order()
            {
                return _stereotype.GetProperty<int?>("Order");
            }

            public bool IsUnique()
            {
                return _stereotype.GetProperty<bool>("IsUnique");
            }

        }

        public class PrimaryKey
        {
            private IStereotype _stereotype;

            public PrimaryKey(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public bool Identity()
            {
                return _stereotype.GetProperty<bool>("Identity");
            }

        }

        public class TextConstraints
        {
            private IStereotype _stereotype;

            public TextConstraints(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public SQLDataTypeOptions SQLDataType()
            {
                return new SQLDataTypeOptions(_stereotype.GetProperty<string>("SQL Data Type"));
            }

            public int? MaxLength()
            {
                return _stereotype.GetProperty<int?>("MaxLength");
            }

            public bool IsUnicode()
            {
                return _stereotype.GetProperty<bool>("IsUnicode");
            }

            public class SQLDataTypeOptions
            {
                public readonly string Value;

                public SQLDataTypeOptions(string value)
                {
                    Value = value;
                }

                public SQLDataTypeOptionsEnum AsEnum()
                {
                    switch (Value)
                    {
                        case "VARCHAR":
                            return SQLDataTypeOptionsEnum.VARCHAR;
                        case "NVARCHAR":
                            return SQLDataTypeOptionsEnum.NVARCHAR;
                        case "TEXT":
                            return SQLDataTypeOptionsEnum.TEXT;
                        case "NTEXT":
                            return SQLDataTypeOptionsEnum.NTEXT;
                        case "DEFAULT":
                            return SQLDataTypeOptionsEnum.DEFAULT;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                public bool IsVARCHAR()
                {
                    return Value == "VARCHAR";
                }
                public bool IsNVARCHAR()
                {
                    return Value == "NVARCHAR";
                }
                public bool IsTEXT()
                {
                    return Value == "TEXT";
                }
                public bool IsNTEXT()
                {
                    return Value == "NTEXT";
                }
                public bool IsDEFAULT()
                {
                    return Value == "DEFAULT";
                }
            }

            public enum SQLDataTypeOptionsEnum
            {
                VARCHAR,
                NVARCHAR,
                TEXT,
                NTEXT,
                DEFAULT
            }
        }

    }
}