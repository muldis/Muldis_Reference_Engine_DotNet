using System;
using System.Collections.Generic;

namespace Muldis.D.Ref_Eng.Core
{
    // Muldis.D.Ref_Eng.Core.MD_Well_Known_Type
    // Enumerates Muldis D types that are considered well-known to this
    // Muldis D language implementation.  Typically these are defined in
    // the Muldis D Foundation language spec even if most of their related
    // operators are not.  Typically each one is either equal to one of the
    // 7 Muldis D Foundation types or it is a Capsule subtype whose label
    // is a simple unqualified Attr_Name.  Typically a given Muldis D value
    // would be a member of several of these types rather than just one.
    // The Muldis D "Any" type is omitted as it implicitly always applies;
    // this omission is subject to be changed.

    internal enum MD_Well_Known_Type
    {
        Excuse,
        Boolean,
        Integer,
        Integer_NN,
        Integer_P,
        Fraction,
        Bits,
        Blob,
        Text,
        Text__Unicode,
        Text__ASCII,
        Array,
        String,
        Set,
        Bag,
        Tuple,
        Tuple_Array,
        Relation,
        Tuple_Bag,
        Interval,
        Capsule,
        Handle,
        Variable,
        Process,
        Stream,
        External,
        Package,
        Function,
        Procedure,
        Signature,
        Signature__Conjunction,
        Signature__Disjunction,
        Signature__Tuple_Attrs_Match_Simple,
        Signature__Tuple_Attrs_Match,
        Signature__Capsule_Match,
        Expression,
        Literal,
        Args,
        Evaluates,
        Array_Selector,
        Set_Selector,
        Bag_Selector,
        Tuple_Selector,
        Capsule_Selector,
        If_Then_Else_Expr,
        And_Then,
        Or_Else,
        Given_When_Default_Expr,
        Guard,
        Factorization,
        Expansion,
        Vars,
        New,
        Current,
        Statement,
        Declare,
        Performs,
        If_Then_Else_Stmt,
        Given_When_Default_Stmt,
        Block,
        Leave,
        Iterate,
        Heading,
        Attr_Name,
        Attr_Name_List,
        Local_Name,
        Absolute_Name,
        Routine_Call,
        Function_Call,
        Function_Call_But_0,
        Function_Call_But_0_1,
        Procedure_Call,
    };

    internal static class Constants
    {
        internal static String[] Strings__Well_Known_Excuses()
        {
            return new String[] {
                "No_Reason",
                "Before_All_Others",
                "After_All_Others",
                "Div_By_Zero",
                "Zero_To_The_Zero",
                "No_Empty_Value",
                "No_Such_Ord_Pos",
                "No_Such_Attr_Name",
                "Not_Same_Heading",
            };
        }

        internal static String[] Strings__Seeded_Non_Positional_Attr_Names()
        {
            return new String[] {
                "Absolute_Name",
                "And_Then",
                "Args",
                "Array_Selector",
                "Array",
                "Attr_Name_List",
                "Attr_Name",
                "Bag_Selector",
                "Bag",
                "Bits",
                "Blob",
                "Block",
                "Boolean",
                "Capsule_Selector",
                "Capsule",
                "Current",
                "Declare",
                "Evaluates",
                "Excuse",
                "Expansion",
                "Expression",
                "External",
                "Factorization",
                "floating",
                "folder",
                "foundation",
                "Fraction",
                "Function_Call_But_0_1",
                "Function_Call_But_0",
                "Function_Call",
                "Function",
                "Given_When_Default_Expr",
                "Given_When_Default_Stmt",
                "Guard",
                "Handle",
                "Heading",
                "If_Then_Else_Expr",
                "If_Then_Else_Stmt",
                "Integer",
                "Integer_NN",
                "Integer_P",
                "Interval",
                "Iterate",
                "Leave",
                "Literal",
                "Local_Name",
                "material",
                "New",
                "Or_Else",
                "package",
                "Package",
                "Performs",
                "Procedure_Call",
                "Procedure",
                "Process",
                "Relation",
                "Routine_Call",
                "Set_Selector",
                "Set",
                "Signature__Capsule_Match",
                "Signature__Conjunction",
                "Signature__Disjunction",
                "Signature__Tuple_Attrs_Match_Simple",
                "Signature__Tuple_Attrs_Match",
                "Signature",
                "Statement",
                "Stream",
                "String",
                "Text__ASCII",
                "Text__Unicode",
                "Text",
                "Tuple_Array",
                "Tuple_Bag",
                "Tuple_Selector",
                "Tuple",
                "used",
                "Variable",
                "Vars",
            };
        }

        internal static String[] Strings__Local_Name_Main_Qualifiers()
        {
            return new String[] {
                "foundation",
                "used",
                "package",
                "folder",
                "material",
                "floating",
            };
        }

        internal static String[] Strings__Absolute_Name_Main_Qualifiers()
        {
            return new String[] {
                "foundation",
                "used",
                "package",
            };
        }

        internal static HashSet<String> Strings__Foundation_Type_Definer_Function_Names()
        {
            return new HashSet<String> {
                "Any",
                "None",
                "Excuse",
                "Boolean",
                "Integer",
                "Integer_NN",
                "Integer_P",
                "Fraction",
                "Bits",
                "Blob",
                "Text",
                "Text__Unicode",
                "Text__ASCII",
                "Array",
                "String",
                "Set",
                "Bag",
                "Tuple",
                "Tuple_Array",
                "Relation",
                "Tuple_Bag",
                "Interval",
                "Capsule",
                "Handle",
                "Variable",
                "Process",
                "Stream",
                "External",
                "Package",
                "Function",
                "Procedure",
                "Signature",
                "Signature__Conjunction",
                "Signature__Disjunction",
                "Signature__Tuple_Attrs_Match_Simple",
                "Signature__Tuple_Attrs_Match",
                "Signature__Capsule_Match",
                "Expression",
                "Literal",
                "Args",
                "Evaluates",
                "Array_Selector",
                "Set_Selector",
                "Bag_Selector",
                "Tuple_Selector",
                "Capsule_Selector",
                "If_Then_Else_Expr",
                "And_Then",
                "Or_Else",
                "Given_When_Default_Expr",
                "Guard",
                "Factorization",
                "Expansion",
                "Vars",
                "New",
                "Current",
                "Statement",
                "Declare",
                "Performs",
                "If_Then_Else_Stmt",
                "Given_When_Default_Stmt",
                "Block",
                "Leave",
                "Iterate",
                "Heading",
                "Attr_Name",
                "Attr_Name_List",
                "Local_Name",
                "Absolute_Name",
                "Routine_Call",
                "Function_Call",
                "Function_Call_But_0",
                "Function_Call_But_0_1",
                "Procedure_Call",
            };
        }

        internal static HashSet<String> Strings__Foundation_NTD_Unary_Function_Names()
        {
            return new HashSet<String> {
                "Integer_opposite",
                "Integer_modulus",
                "Integer_factorial",
                "Array_all_unique",
                "Array_unique",
                "Array_nest",
                "Array_unnest",
                "Array_to_Bag",
                "Array_count",
                "Bag_singular",
                "Bag_only_member",
                "Bag_all_unique",
                "Bag_unique",
                "Bag_nest",
                "Bag_unnest",
                "Bag_count",
                "Bag_unique_count",
                "Tuple_degree",
                "Tuple_heading",
                "Capsule_label",
                "Capsule_attrs",
            };
        }

        internal static HashSet<String> Strings__Foundation_Binary_Function_Names()
        {
            return new HashSet<String> {
                "same",
                "Integer_in_order",
                "Integer_plus",
                "Integer_minus",
                "Integer_times",
                "Integer_multiple_of",
                "Integer_divided_by_rtz",
                "Integer_nn_power",
                "Array_substring_of",
                "Array_overlaps_string",
                "Array_disjoint_string",
                "Array_catenate",
                "Array_replicate",
                "Array_multiplicity",
                "Array_any",
                "Array_except",
                "Array_intersect",
                "Array_union",
                "Array_exclusive",
                "Array_where",
                "Array_map",
                "Array_reduce",
                "Array_order_using",
                "Array_at",
                "Array_ord_pos_succ_all_matches",
                "Bag_multiplicity",
                "Bag_subset_of",
                "Bag_overlaps_members",
                "Bag_disjoint_members",
                "Bag_any",
                "Bag_member_plus",
                "Bag_except",
                "Bag_intersect",
                "Bag_union",
                "Bag_exclusive",
                "Bag_where",
                "Bag_map",
                "Bag_reduce",
                "Bag_order_using",
                "Tuple_D1_select",
                "Tuple_subheading_of",
                "Tuple_overlaps_heading",
                "Tuple_disjoint_heading",
                "Tuple_except_heading",
                "Tuple_intersect_heading",
                "Tuple_union_heading",
                "Tuple_exclusive_heading",
                "Tuple_rename",
                "Tuple_on",
                "Tuple_update",
                "Tuple_extend",
                "Tuple_at",
                "Tuple_any_attrs",
                "Tuple_attrs_where",
                "Tuple_attrs_map",
                "Tuple_attrs_reduce",
                "Capsule_select",
                "Capsule_at",
            };
        }

        internal static HashSet<String> Strings__Foundation_Ternary_Function_Names()
        {
            return new HashSet<String> {
                "Array_has_n",
                "Array_insert_n",
                "Array_remove_n",
                "Array_slice_n",
                "Bag_has_n",
                "Bag_insert_n",
                "Bag_remove_n",
            };
        }
    }
}
