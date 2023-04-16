import React, { Component } from 'react';

export class SaleItems extends Component {
    static displayName = SaleItems.name;

    constructor(props) {
        super(props);
        this.state = { saleitems: [], loading: true };
        this.onClick = this.onClick.bind(this);
    }
    onClick(e) {
        this.props.onRemove(this.state.data);
    }

    //onClick(e) {
    //    this.props.OnRemove(this.state.data);
    //}
    //render() {
    //    return <div>
    //        <p><b>{this.state.data.name}</b></p>
    //        <p>Цена {this.state.data.price}</p>
    //        <p><button onClick={this.onClick}>Удалить</button></p>
    //    </div>;
    //}

    componentDidMount() {
        this.populateSaleItemsData();
    }

    static renderSaleItemsTable(saleitems) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Short name</th>
                        <th>Description</th>
                        <th>Count</th>
                    </tr>
                </thead>
                <tbody>
                    {saleitems.map(saleitem =>
                        <tr key={saleitem.id}>
                            <td>{saleitem.shortName}</td>
                            <td>{saleitem.description}</td>
                            <td>{saleitem.count}</td>
                            <td><button onClick={this.onClick}>Delete</button></td>
                            <td><button></button></></td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : SaleItems.renderSaleItemsTable(this.state.saleitems);

        return (
            <div>
                <h1 id="tabelLabel" >Sale items</h1>
                <p>List of available items.</p>
                {contents}
            </div>
        );
    }

    async populateSaleItemsData() {
        const response = await fetch('saleitem');
        const data = await response.json();
        this.setState({ saleitems: data, loading: false });
    }
}
