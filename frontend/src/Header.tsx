function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-dark">
      <div className="col subtitle">
        <h2 className="text-white">{props.title}</h2>
      </div>
    </header>
  );
}

export default Header;
