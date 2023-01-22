import React, { Component } from 'react';

export class SaleItems extends Component {
    static displayName = SaleItems.name;

    constructor(props) {
        super(props);
        this.state = { saleitems: [], loading: true };
    }

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
                        <tr key={saleitem.shortname}>
                            <td>{saleitem.description}</td>
                            <td>{saleitem.count}</td>
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
