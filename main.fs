module Assignment

type Tree =
    | Node of Tree * Tree
    | Leaf of int
    // let tree = Node(Node(Leaf(1), Node(Leaf(2), Leaf(3))), Node(Node(Leaf(4), Leaf(5)), Leaf(6)))
    // let tree1 = Node(Leaf(2), Leaf(3))


let rec prod (t:Tree) :int =
 let (a,b)
    match t with
    // leaf only has int value
    |Leaf i

let rec map (f:int->int) (t:Tree) :Tree =
    t

let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""
